using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObj : MonoBehaviour
{
    public float time;
    public bool esPepitaProp;
    public double cantidadPepita;
    public int puntoMorir;

    void OnEnable()
    {
        puntoMorir = 0;
        if (!esPepitaProp)
        {
            Invoke(nameof(Quitar), time);
        }
        else
        {
            Invoke(nameof(Verif), 0.1f);
        }
      
    }
    void Verif()
    {
        if (!esPepitaProp)
        {
            Invoke(nameof(Quitar), time);
        }
    }
    void Quitar()
    {
        if (!esPepitaProp)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }    
    }
    
    void Update()
    {
        
    }
    private void OnDisable()
    {
        cantidadPepita = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (esPepitaProp && collision.CompareTag("Dworf") && puntoMorir <= 0)
        {
            puntoMorir = 1;
            collision.GetComponent<Dworfs>().cargoActual += cantidadPepita;
            ObjectPool.ReturnObjectToPool(gameObject);
        }
    }
}
