using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carambola : MonoBehaviour
{

    public int puntoRotar;
    public GameObject verdes;
    public int puntoColision;
    public int puntoMorir;
    public float speed;
    public int puntoHover;
    void OnEnable()
    {
        speed = 6.5f;
        transform.localScale = new Vector3(1, 1, 0);
        puntoHover = 0;
        GetComponent<TrailRenderer>().time = 0;
        puntoMorir = 0;
        verdes = GameObject.FindGameObjectWithTag("Verdes");
        transform.rotation = Quaternion.Euler(new Vector3(0,0,Random.Range(0,180)));
        Invoke(nameof(QuitarRotar), 0.6f);
        Invoke(nameof(Verif), 0.04f);
        Invoke(nameof(ActTrail), 0.2f);
        puntoRotar = 0;
        puntoColision = 0;


    }
    void ActTrail()
    {
        GetComponent<TrailRenderer>().time = 0.75f;
    }
    void Verif()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Verif), 0.04f);
            if (puntoColision == 2)
            {

                transform.position = Vector3.MoveTowards(transform.position, verdes.transform.position, speed * Time.deltaTime);
                speed += 0.15f;
            }
            else if (puntoColision == 1)
            {

                transform.position = Vector3.MoveTowards(transform.position, -verdes.transform.position, 2f * Time.deltaTime);
                speed += 0.1f;
            }
            if (puntoRotar <= 0)
            {

                transform.localScale = new Vector3(transform.localScale.x + 0.011f, transform.localScale.y + 0.011f, 0);
            }
            else
            {

                transform.localScale = new Vector3(transform.localScale.x - 0.011f, transform.localScale.y - 0.011f, 0);
            }
        }
        
    }
    void QuitarRotar()
    {
      
        if (puntoMorir <= 0)
        {
            puntoRotar = 1;
            Invoke(nameof(Rotar), 0.6f);
        }
    
    }
    void Rotar()
    {
      
        if (puntoMorir <= 0)
        {
            puntoRotar = 0;
            Invoke(nameof(QuitarRotar), 0.6f);
        }
     
    }
    private void OnDisable()
    {
        GetComponent<TrailRenderer>().time = 0;
        puntoColision = 0;
        puntoMorir = 1;
    }
    void Update()
    {
       
    }
    private void OnMouseEnter()
    {
        if (puntoHover <= 0)
        {
            puntoHover = 1;
            puntoColision = 1;
            Invoke(nameof(IrHaciaRecurso), 0.3f);
        }
      
    }
    void IrHaciaRecurso()
    {
        puntoColision = 2;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Verdes"))
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
    }
}
