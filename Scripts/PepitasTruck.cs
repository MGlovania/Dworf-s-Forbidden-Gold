using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PepitasTruck : MonoBehaviour
{
    public GameObject manager;
    public GameObject prefabPopUp;
    void OnEnable()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CamionCargamento") && collision.GetComponent<CamionDeCargo>().cantidad < collision.GetComponent<CamionDeCargo>().cantidadMax)
        {
            GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + Vector3.up / 2, Quaternion.identity);
            popUp.GetComponentInChildren<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().pesoPiedra.ToString("F0");
            collision.GetComponent<CamionDeCargo>().cantidad += manager.GetComponent<Recursos>().pesoPiedra;
            ObjectPool.ReturnObjectToPool(gameObject);
        }
      

    }


}
