using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Succionador : MonoBehaviour
{

    public GameObject manager;
    public GameObject prefabParticulas;
    public GameObject camion;
    public GameObject camionCargo;
    public GameObject camionCargo2;
    public GameObject camionCargo3;
    public GameObject prefabPepita;
    public int cantidadASuccionar;
    public int cantidadASuccionar2;
    public float timeRecharge;
    public float timeSuccionar;
    void Start()
    {
       
        cantidadASuccionar = manager.GetComponent<Recursos>().cantidadASuccionar;
        timeRecharge = manager.GetComponent<Recursos>().timeRecharge;
        timeSuccionar = manager.GetComponent<Recursos>().timeSuccion;
        Invoke(nameof(Verif), timeSuccionar);
        Invoke(nameof(Actualizar), 1f);
    }
    void Actualizar()
    {
        Invoke(nameof(Actualizar), 1f);
        timeRecharge = manager.GetComponent<Recursos>().timeRecharge;
        timeSuccionar = manager.GetComponent<Recursos>().timeSuccion;
    }
    void Verif()
    {
        if (cantidadASuccionar2 < cantidadASuccionar && manager.GetComponent<Recursos>().permitirSuccion >= 1)
        {
          
            Invoke(nameof(Verif), timeSuccionar);
            if (manager.GetComponent<Recursos>().puntoCamionEsperando == 0 && manager.GetComponent<Recursos>().puntoSuccion == 0 && manager.GetComponent<Recursos>().cantidadPepitasEnSuelo >= 1)
            {
                if (manager.GetComponent<Recursos>().puntoColliderSonidoPiedra >= 1)
                {
                    AudioManager.instance.PlaySFX("SuctionSfx");
                }
                cantidadASuccionar2 += 1;
                manager.GetComponent<Recursos>().puntoSuccion = 1;
                Vector2 direction = (camion.transform.position + Vector3.up * Random.Range(6f, 7f)) - transform.position;

                transform.right = direction;
                GameObject obj = ObjectPool.SpawnObject(prefabPepita, transform.position + Vector3.up, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(6, 7);
                transform.rotation = Quaternion.Euler(Vector3.zero);
                ObjectPool.SpawnObject(prefabParticulas, transform.position + Vector3.down / 2 + Vector3.right / 2, Quaternion.identity);
            }
        }
        else
        {
            Invoke(nameof(Recharge), 0.1f);

        }
       
    }
    void Recharge()
    {
        cantidadASuccionar2 = 0;
        Invoke(nameof(Verif), timeRecharge);
    }
  
}
