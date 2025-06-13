using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hada : MonoBehaviour
{

    public int moverDerecha;
    public int moverIzquierda;
    public float speed;
    public int mover;
    public GameObject prefabParticulas;
    public int puntoMorir;
    public int range;
    public GameObject manager;
    public GameObject aldeano;
    public GameObject recuadroBuffoAldeano;
    public GameObject recuadroBuffoGeneral;

    void OnEnable()
    {
        mover = 0;
        puntoMorir = 0;
        manager = GameObject.FindGameObjectWithTag("Manager");
        recuadroBuffoAldeano = GameObject.FindGameObjectWithTag("BuffoAldeanos");
        recuadroBuffoGeneral = GameObject.FindGameObjectWithTag("BuffoGeneral");


        Invoke(nameof(MoverArriba), 1.3f);
        Invoke(nameof(Verif), 0.1f);
        Invoke(nameof(Particula), 0.25f);
    }
    private void OnMouseUp()
    {      
       if (range == 0)
        {
            recuadroBuffoGeneral.SetActive(false);
            recuadroBuffoGeneral.SetActive(true);
            recuadroBuffoGeneral.transform.position = transform.position;
            manager.GetComponent<Recursos>().puntoBuffoHadaMasDañoDworfs += 1;
            manager.GetComponent<Recursos>().magnitudBuffoMasDañoMostrarPorcentaje += manager.GetComponent<Recursos>().magnitudBuffoHadasMostrarPorcentaje;
            manager.GetComponent<Recursos>().dañoClick *= manager.GetComponent<Recursos>().magnitudBuffoHadas;
            manager.GetComponent<Recursos>().dañoDworfsMineros *= manager.GetComponent<Recursos>().magnitudBuffoHadas;
        }    
        else if (range == 2)
        {
            recuadroBuffoGeneral.SetActive(false);
            recuadroBuffoGeneral.SetActive(true);
            recuadroBuffoGeneral.transform.position = transform.position;
            manager.GetComponent<Recursos>().puntoBuffoHadaMasValor += 1;
            manager.GetComponent<Recursos>().magnitudBuffoMasValorMostrarPorcentaje += manager.GetComponent<Recursos>().magnitudBuffoHadasMostrarPorcentaje;
            manager.GetComponent<Recursos>().valorPiedra *= manager.GetComponent<Recursos>().magnitudBuffoHadas;
        }
        else if (range == 3)
        {
            recuadroBuffoGeneral.SetActive(false);
            recuadroBuffoGeneral.SetActive(true);
            recuadroBuffoGeneral.transform.position = transform.position;
            manager.GetComponent<Recursos>().puntoBuffoHadaMasGemas += 1;
            manager.GetComponent<Recursos>().magnitudBuffoMasGemasMostrarPorcentaje += manager.GetComponent<Recursos>().magnitudBuffoHadasMostrarPorcentaje;
        }
        else
        {
            recuadroBuffoGeneral.SetActive(false);
            recuadroBuffoGeneral.SetActive(true);
            recuadroBuffoGeneral.transform.position = transform.position;
            manager.GetComponent<Recursos>().puntoBuffoHadaMasDañoDworfs += 1;
            manager.GetComponent<Recursos>().magnitudBuffoMasDañoMostrarPorcentaje += manager.GetComponent<Recursos>().magnitudBuffoHadasMostrarPorcentaje;
            manager.GetComponent<Recursos>().dañoClick *= manager.GetComponent<Recursos>().magnitudBuffoHadas;
            manager.GetComponent<Recursos>().dañoDworfsMineros *= manager.GetComponent<Recursos>().magnitudBuffoHadas;
        }
        if (manager.GetComponent<Recursos>().puntoMejoraObtenerDworfsPorHadas >= 1)
        {
            range = Random.Range(0, 100);
            if (range == 0 + manager.GetComponent<Recursos>().probObtenerDworfsPorHada)
            {
                ObjectPool.SpawnObject(aldeano, new Vector3(-20, -3, 0), Quaternion.identity);
                recuadroBuffoAldeano.SetActive(false);
                recuadroBuffoAldeano.SetActive(true);
                recuadroBuffoAldeano.transform.position = transform.position;
                manager.GetComponent<Recursos>().puntoBuffoMasAldeanos = 1;
            }
        }
      
        ObjectPool.ReturnObjectToPool(gameObject);
    }
    void Particula()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Particula), 0.25f);
            ObjectPool.SpawnObject(prefabParticulas, transform.position, Quaternion.identity);
        }
        range = Random.Range(0, 6);
        if (range == 0)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
       else if (range == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        else if (range == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (range == 3)
        {
            GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        else if (range == 4)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (range == 5)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }

    }
    void Verif()
    {
        if (moverIzquierda >= 1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    void MoverArriba()
    {
        Invoke(nameof(MoverAbajo), 1.3f);
        mover = 1;
    }
    void MoverAbajo()
    {
        mover = 0;
        Invoke(nameof(MoverArriba), 1.3f);
    }
    private void OnDisable()
    {
        puntoMorir = 1;
           moverDerecha = 0;
        moverIzquierda = 0;

    }
    void Update()
    {
        if (moverIzquierda >= 1 && mover == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.left + (transform.position + Vector3.up / 4), speed * Time.deltaTime);
        }
        else if (moverIzquierda >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.left + (transform.position + Vector3.down / 4), speed * Time.deltaTime);
        }
        if (moverDerecha >= 1 && mover == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.right + (transform.position + Vector3.up / 4), speed * Time.deltaTime);
        }
        else if(moverDerecha >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.right + (transform.position + Vector3.down / 4), speed * Time.deltaTime);
        }

    }
}
