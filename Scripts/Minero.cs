using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minero : MonoBehaviour
{
    public float speed;
    public float speedAtacar;
    public float energia;
    public double daño;

    public Vector3 pos;
    public int minar;
    public int coolDown;

    public GameObject burbuja;
    public GameObject pico;
    public GameObject piedra;
    public GameObject manager;
    public Animator anim;
    public SpriteRenderer sp;

    public int puntoBurbuja;

    public int puntoSleep;
    public GameObject player;
    public GameObject particulasQuitar;

    public int puntoMorir;
    public int cantidadMineros;

    public int puntoPicoSpawneado;
    void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        puntoSleep = 0;
        sp.flipX = false;
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        puntoBurbuja = 0;
        coolDown = 0;
        puntoMorir = 0;
        manager = GameObject.FindGameObjectWithTag("Manager");
        piedra = GameObject.FindGameObjectWithTag("Piedra");
        speed = manager.GetComponent<Recursos>().speedMiners;
        speedAtacar = manager.GetComponent<Recursos>().speedAtaqueMiners;
        energia = manager.GetComponent<Recursos>().energiaMiners;
        daño = manager.GetComponent<Recursos>().dañoDworfsMineros;
        pos = new Vector3(Random.Range(2.84f, 3.24f), -3.16f, 0);
        Invoke(nameof(Verif), 0.15f);
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
    void Verif()
    {
      
        if (puntoSleep <= 0 && puntoMorir <= 0)
        {
            Invoke(nameof(Verif), 0.15f);
        }
    
        if (minar >= 1 && coolDown <= 0 && energia >= 1)
        {
            coolDown = 1;
            Invoke(nameof(Minar), speedAtacar);
        }
    }
    void Minar()
    {
        coolDown = 0;
      
        Invoke(nameof(Dañar), 1.2f);
       
       
       // if (manager.GetComponent<Recursos>().cantidadPicosEnPantalla >= 15)
       // {
       //     coolDown = 0;
       //     piedra.GetComponent<Piedra>().DañoPico();
       // }
        if (energia > 0 && puntoMorir <= 0)
        {         
            ObjectPool.SpawnObject(pico, transform.position,Quaternion.Euler(new Vector3(0,0, -21.4f)));
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up / 1.5f, 2);
        }

    }
    void Dañar()
    {
        piedra.GetComponent<Piedra>().DañoPico();
    }
    private void OnDisable()
    {
        puntoPicoSpawneado = 0;
      
        puntoSleep = 1;
        puntoMorir = 1;
    }
    void Update()
    {

        if (energia > 0)
        {
            energia -= Time.deltaTime;
        }
       

        if (energia > 0 && transform.position != pos)
        {
            if (anim.GetBool("Caminar") != true)
            {
                anim.SetBool("Caminar", true);
            }
            transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Caminar", false);
        }
        if(energia <= 0)
        {          
            if (sp.flipX != true)
            {
                sp.flipX = true;
            }
            if (anim.GetBool("Caminar") != true)
            {
                anim.SetBool("Caminar", true);
            }
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.left, speed * Time.deltaTime);
        }
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CasaMineros"))
        {
            minar = 0;
            ObjectPool.ReturnObjectToPool(gameObject);
        }
        if (collision.CompareTag("MinerosMinar"))
        {
            minar = 1;
        }
    }
}
