using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ReturnParticulas : MonoBehaviour
{
    public float time;
    public bool esSubEmitter;
    public bool esSubEmitter2;
    public bool esPocionValor;
    public bool esPopUpZafiro;
    public GameObject particulaSub;
    public GameObject particulaSub2;
    public GameObject manager;
    public GameObject popUpZafiro;
    void OnEnable()
    {
        Invoke(nameof(Quitar), time);
        if (esPopUpZafiro)
        {
            manager = GameObject.FindGameObjectWithTag("Manager");
        }
    }
    void Quitar()
    {
        if (esSubEmitter)
        {
            if (esPocionValor)
            {
                ObjectPool.SpawnObject(particulaSub, transform.position + Vector3.right * 5.75f, Quaternion.identity);
            }
            else
            {
                ObjectPool.SpawnObject(particulaSub, transform.position, Quaternion.identity);
            }
        }
        if (esSubEmitter2)
        {
            if (esPocionValor)
            {
                ObjectPool.SpawnObject(particulaSub2, transform.position + Vector3.right * 5.75f, Quaternion.identity);
            }
            else
            {
                ObjectPool.SpawnObject(particulaSub2, transform.position, Quaternion.identity);
            }
          
        }
        if (esPopUpZafiro)
        {
            if (manager.GetComponent<Recursos>().puntoColliderSonidoZafiroYTal >= 1)
            {
                AudioManager.instance.PlaySFX("PepitaDeposito");
            }
            GameObject popUp = ObjectPool.SpawnObject(popUpZafiro, transform.position + Vector3.up / 2, Quaternion.identity);
            popUp.GetComponentInChildren<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().valorZafiro.ToString("F1");
        }
     
        ObjectPool.ReturnObjectToPool(gameObject);
        
    }

}
