using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PepitasTruck : MonoBehaviour
{
    public GameObject manager;
    public GameObject prefabPopUp;
    public int range;
    public GameObject deposito;
    public GameObject prefabPepitaProp;
    void OnEnable()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        deposito = GameObject.FindGameObjectWithTag("Deposito");
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CamionCargamento") && collision.GetComponent<CamionDeCargo>().cantidad < collision.GetComponent<CamionDeCargo>().cantidadMax)
        {
            if (manager.GetComponent<Recursos>().puntoColliderSonidoZafiroYTal >= 1)
            {
                AudioManager.instance.PlaySFX("PepitaTruck");
            }
            //if (manager.GetComponent<MejorasTruck>().nivelMejoraMasVelocidad >= 1)
            //{
            //    range = Random.Range(0, 100);
            //    if (range <= 0 + (manager.GetComponent<MejorasTruck>().nivelMejoraMasVelocidad * 10))
            //    {
            //        Vector2 direction = (deposito.transform.position + Vector3.up * 7) - transform.position;
            //        transform.right = direction;
            //        GameObject obj = ObjectPool.SpawnObject(prefabPepitaProp, transform.position + Vector3.up, Quaternion.identity);
            //        obj.GetComponent<Rigidbody2D>().velocity = transform.right * 7;
            //        obj.GetComponent<ReturnObj>().esPepitaProp = false;
            //        transform.rotation = Quaternion.Euler(Vector3.zero);
            //    }            
            //}
            //else
            //{

            // }
            GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + Vector3.up / 2, Quaternion.identity);
            popUp.GetComponentInChildren<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().pesoPiedra.ToString("F0");
            collision.GetComponent<CamionDeCargo>().cantidad += manager.GetComponent<Recursos>().pesoPiedra;
            ObjectPool.ReturnObjectToPool(gameObject);

        }
      

    }


}
