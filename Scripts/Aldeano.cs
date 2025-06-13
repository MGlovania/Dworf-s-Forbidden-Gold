using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Aldeano : MonoBehaviour
{
    public float speed;
    public int moverIzquierda;
    public int moverDerecha;
    public int puntoMover;
    public int moverHaciaElCentro;
    public int range;
    public Rigidbody2D rb;
    public GameObject manager;
    public GameObject popUpFe;
    public GameObject popUpFlores;
    public int puntoMorir;

    public GameObject player;
    public GameObject particulasQuitar;
    void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("Manager");
  
        moverIzquierda = 0;
        moverDerecha = 0;
        rb = gameObject.GetComponent<Rigidbody2D>();
        Invoke(nameof(MoverAleatorio), Random.Range(1f, 5f));
        Invoke(nameof(VerifFe), 3f);
        Invoke(nameof(VerifFlores), 3.5f);
  
        puntoMorir = 0;
        Invoke(nameof(VerifPrestigio), 1f);
    }
    void VerifPrestigio()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(VerifPrestigio), 1f);
            if (player.GetComponent<PJ>().puntoPrestigio >= 1)
            {
                ObjectPool.SpawnObject(particulasQuitar, transform.position, Quaternion.identity);
                ObjectPool.ReturnObjectToPool(gameObject);
            }
        }
        
    }
    void VerifFe()
    {
        Invoke(nameof(VerifFe), 3f);
        if (manager.GetComponent<Construir>().puntoCatedralCosntruida >= 1 && puntoMorir <= 0)
        {
            GameObject popUp = ObjectPool.SpawnObject(popUpFe, transform.position + Vector3.up / 4 + Vector3.right / 9, Quaternion.identity);
            popUp.GetComponentInChildren<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().valorDworfsFe.ToString("F0");
            manager.GetComponent<Recursos>().cantidadFe += manager.GetComponent<Recursos>().valorDworfsFe;
        }
    }
    void VerifFlores()
    {
        Invoke(nameof(VerifFlores), 3f);
        if (manager.GetComponent<Construir>().puntoCatedralCosntruida >= 1 && puntoMorir <= 0)
        {

        }
    }
    void MoverAleatorio()
    {

        GetComponent<Animator>().SetBool("Caminar", true);
        puntoMover = 1;
        if (moverDerecha == 1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            moverIzquierda = 1;
            moverDerecha = 0;
        }
        else if (moverIzquierda == 1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            moverDerecha = 1;
            moverIzquierda = 0;
        }
        else
        {
            range = Random.Range(0, 2);
            if (range == 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
                moverIzquierda = 1;
            }
            if (range == 1)
            {
                GetComponent<SpriteRenderer>().flipX = false;
                moverDerecha = 1;
            }
        }
    

        Invoke(nameof(Quieto), Random.Range(0.45f, 1.45f));
    }
    void Quieto()
    {
        GetComponent<Animator>().SetBool("Caminar", false);

        puntoMover = 0;
        Invoke(nameof(MoverAleatorio), Random.Range(1f, 5f));
    }

    private void OnDisable()
    {
        puntoMorir = 1;
    }
    void Update()
    {
      
        if (moverDerecha == 1 && puntoMover >= 1 && moverHaciaElCentro <= 0)
        {

            rb.velocity = new Vector2(1 * speed, rb.velocity.y);

        }
        else if (moverIzquierda == 1 && puntoMover >= 1 && moverHaciaElCentro <= 0)
        {

            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);

        }
        else if (moverHaciaElCentro >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-25,-3,0), speed * Time.deltaTime);
            //  rb.velocity = new Vector2(centro.transform.position.x * speed, rb.velocity.y);

        }
    }
    void QuitarCentro()
    {
        moverHaciaElCentro = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LimiteAldeanos"))
        {
            moverHaciaElCentro = 1;
            Invoke(nameof(QuitarCentro), 1.5f);
        }
    }
}
