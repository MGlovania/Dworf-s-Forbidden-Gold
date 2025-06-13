using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Piedra : MonoBehaviour
{
    public GameObject prefabParticulas;
    public GameObject prefabPepita;
    public GameObject target;
    public GameObject manager;

    public double vida;
    public double vidaMax;

    public GameObject prefabPopUp;

    public Slider vidaSlider;
    public int range;

    public TMP_Text cantidadPepitasActualText;
    void Start()
    {
        vidaMax = manager.GetComponent<Recursos>().vidaMaxPiedra;
        vida = vidaMax;
      
        vidaSlider.maxValue = (float)vidaMax;
        vidaSlider.value = (float)vidaMax;
        Invoke(nameof(Verif), 0.25f);
    }
    void Verif()
    {
        vidaSlider.maxValue = (float)vidaMax;
    }

    void Update()
    {
        PlayerPrefs.SetString("VidaMax", vidaMax.ToString());
    }
    private void OnMouseUp()
    {
        if (manager.GetComponent<Recursos>().cantidadPepitasActual < manager.GetComponent<Recursos>().cantidadPepitasMax && manager.GetComponent<Intro>().puntoIntro >= 1)
        {
            range = Random.Range(0, 100);
            if (range == 0 + manager.GetComponent<Recursos>().probCrit && manager.GetComponent<Recursos>().probCrit >= 1)
            {
                GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + new Vector3(Random.Range(-0.4f, 0.65f), Random.Range(0.75f, 1.1f), 0), Quaternion.identity);
                popUp.GetComponentInChildren<TMP_Text>().text = "-" + (manager.GetComponent<Recursos>().dañoClick * manager.GetComponent<Recursos>().dañoCrit).ToString("F0");
                vida -= manager.GetComponent<Recursos>().dañoClick * manager.GetComponent<Recursos>().dañoCrit;
                vidaSlider.value -= ((float)manager.GetComponent<Recursos>().dañoClick * manager.GetComponent<Recursos>().dañoCrit);
            }
            else
            {
                GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + new Vector3(Random.Range(-0.4f, 0.65f), Random.Range(0.75f, 1.1f), 0), Quaternion.identity);
                popUp.GetComponentInChildren<TMP_Text>().text = "-" + manager.GetComponent<Recursos>().dañoClick.ToString("F0");
                vida -= manager.GetComponent<Recursos>().dañoClick;
                vidaSlider.value -= (float)manager.GetComponent<Recursos>().dañoClick;
            }
         
        
            GetComponent<Animator>().SetBool("Click", true);
            Invoke(nameof(QuitarAnim), 0.1f);

            if (vida <= 0)
            {
                if (manager.GetComponent<Intro>().puntoIntroPrimeraPepita <= 0)
                {
                    manager.GetComponent<Intro>().puntoIntroPrimeraPepita = 1;
                    PlayerPrefs.SetInt("PuntoIntroPrimeraPepita", manager.GetComponent<Intro>().puntoIntroPrimeraPepita);
                }
               
             
                manager.GetComponent<Recursos>().cantidadPepitasActual += manager.GetComponent<Recursos>().pesoPiedra;
                Vector2 direction = (target.transform.position + Vector3.up * Random.Range(5f, 11f)) - transform.position;
                transform.right = direction;
                GameObject obj = ObjectPool.SpawnObject(prefabPepita, transform.position + Vector3.up / 2f, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(3.4f, 5.35f);
                transform.rotation = Quaternion.Euler(Vector3.zero);
                ObjectPool.SpawnObject(prefabParticulas, transform.position, Quaternion.identity);
                vida = vidaMax;
              
                vidaSlider.value = (float)vidaMax;
              
            }
           
        }
      
      
    }
    public void DañoPico()
    {
        GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + new Vector3(Random.Range(-0.4f, 0.65f), Random.Range(0.75f, 1.1f), 0), Quaternion.identity);
        popUp.GetComponentInChildren<TMP_Text>().text = "-" + manager.GetComponent<Recursos>().dañoDworfsMineros.ToString("F0");
        vida -= manager.GetComponent<Recursos>().dañoDworfsMineros;
        if (vida <= 0 && manager.GetComponent<Recursos>().cantidadPepitasActual < manager.GetComponent<Recursos>().cantidadPepitasMax)
        {
            manager.GetComponent<Recursos>().cantidadPepitasActual += manager.GetComponent<Recursos>().pesoPiedra;
            GetComponent<Animator>().SetBool("Click", true);
            Invoke(nameof(QuitarAnim), 0.1f);
            Vector2 direction = (target.transform.position + Vector3.up * Random.Range(5f, 11f)) - transform.position;
            transform.right = direction;
            GameObject obj = ObjectPool.SpawnObject(prefabPepita, transform.position + Vector3.up / 2f, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(3.4f, 5.35f);
            transform.rotation = Quaternion.Euler(Vector3.zero);
            ObjectPool.SpawnObject(prefabParticulas, transform.position, Quaternion.identity);
            vida = vidaMax;
        }
    }
    void QuitarAnim()
    {
        GetComponent<Animator>().SetBool("Click", false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pico"))
        {
            GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + new Vector3(Random.Range(-0.4f, 0.65f), Random.Range(0.75f, 1.1f), 0), Quaternion.identity);
            popUp.GetComponentInChildren<TMP_Text>().text = "-" + manager.GetComponent<Recursos>().dañoDworfsMineros.ToString("F0");
            vida -= manager.GetComponent<Recursos>().dañoDworfsMineros;
            if (vida <= 0 && manager.GetComponent<Recursos>().cantidadPepitasActual < manager.GetComponent<Recursos>().cantidadPepitasMax)
            {              
                manager.GetComponent<Recursos>().cantidadPepitasActual += manager.GetComponent<Recursos>().pesoPiedra;
                GetComponent<Animator>().SetBool("Click", true);
                Invoke(nameof(QuitarAnim), 0.1f);
                Vector2 direction = (target.transform.position + Vector3.up * Random.Range(5f, 11f)) - transform.position;
                transform.right = direction;
                GameObject obj = ObjectPool.SpawnObject(prefabPepita, transform.position + Vector3.up / 2f, Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(3.4f, 5.35f);
                transform.rotation = Quaternion.Euler(Vector3.zero);
                ObjectPool.SpawnObject(prefabParticulas, transform.position, Quaternion.identity);
                vida = vidaMax;
            }
            manager.GetComponent<Recursos>().cantidadPicosEnPantalla -= 1;
            ObjectPool.ReturnObjectToPool(collision.gameObject);
        }
      
    }
}

