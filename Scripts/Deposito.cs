using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deposito : MonoBehaviour
{

    public int puntoCamionColision;
    public GameObject prefabCollectors;
    public GameObject deposito;
    public int cantidadAMandarCollectos;
    void Start()
    {
        Invoke(nameof(Verif), 0.25f);
    }

    void Verif()
    {
        Invoke(nameof(Verif), 0.25f);
        if (puntoCamionColision >= 1 && GetComponent<Recursos>().cantidadDworfsCollectors >= 1)
        {
            puntoCamionColision = 0;
            Invoke(nameof(MandarCollectors), 0.06f);
        }

    }
    public void MandarCollectors()
    {
        if (cantidadAMandarCollectos < GetComponent<Recursos>().cantidadDworfsCollectors)
        {
            ObjectPool.SpawnObject(prefabCollectors, deposito.transform.position, Quaternion.identity);
            cantidadAMandarCollectos += 1;
            Invoke(nameof(MandarCollectors), 0.25f);
          
        }
       
    }

}
