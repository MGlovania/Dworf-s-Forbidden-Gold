using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dworfs : MonoBehaviour
{
    public GameObject manager;

    public bool esCollector;
    public double cargoActual;
    public double cargoAFuturo;
    public double capacidadMax;
    public float speedCollector;
    public float speedCollectorRecolectar;
    public GameObject truck;  
    public GameObject deposito;
    public GameObject prefabPepitaProp;
    public int puntoCollectando;
    public int puntoCollectando2;
    public int puntoCollectando3;
    public int puntoCollectando4;
    public int puntoDescargando;
    public int anularMovimiento;

    public bool esMinero;
   

    public GameObject prefabPopUp;
    public GameObject player;
    public GameObject particulasQuitar;

    public int puntoMorir;
    void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anularMovimiento = 0;
        puntoMorir = 0;
        puntoDescargando = 0;
        cargoActual = 0;
        cargoAFuturo = 0;
        manager = GameObject.FindGameObjectWithTag("Manager");
        deposito = GameObject.FindGameObjectWithTag("Deposito");
        if (esCollector)
        {
            truck = GameObject.FindGameObjectWithTag("CamionCargamento");        
            speedCollector = manager.GetComponent<Recursos>().speedCollectors;
            capacidadMax = manager.GetComponent<Recursos>().cargoMaxCollectors;
            speedCollectorRecolectar = manager.GetComponent<Recursos>().speedCollectorsRecolectar;
        }
        Invoke(nameof(Verif), 0.25f);
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
        if (truck.GetComponent<CamionDeCargo>().cantidad == 0)
        {
            Invoke(nameof(Anular), 0.75f);
        }
        if (truck.GetComponent<CamionDeCargo>().collectorsQuitar == 1 && cargoActual <= 0)
        {
            Invoke(nameof(Quitar), 0.5f);
        }
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Verif), 0.25f);
        }
        if (esCollector && cargoActual < capacidadMax)
        {
            GetComponent<Animator>().SetBool("Caminar", true);
        }
        else if (esCollector)
        {
            GetComponent<Animator>().SetBool("Caminar", false);
        }
        if (puntoCollectando >= 1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }       
      

    }
    void Anular()
    {
        anularMovimiento = 1;
    }
    void Quitar()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
    }
    void Recolectar()
    {
        if (truck.GetComponent<CamionDeCargo>().cantidad >= 1 && cargoAFuturo < capacidadMax)
        {
          
            Vector2 direction = (transform.position + Vector3.up * Random.Range(6f, 7f)) - transform.position;
            transform.right = direction;
            GameObject obj = ObjectPool.SpawnObject(prefabPepitaProp, transform.position + Vector3.up, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(6, 7);
            obj.GetComponent<ReturnObj>().esPepitaProp = true;
            obj.GetComponent<ReturnObj>().cantidadPepita = manager.GetComponent<Recursos>().cargoMaxCollectors / 10;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up / 1.5f, 2);
            transform.rotation = Quaternion.Euler(Vector3.zero);      
            Invoke(nameof(Recolectar), speedCollectorRecolectar);
            truck.GetComponent<CamionDeCargo>().cantidad -= manager.GetComponent<Recursos>().pesoPiedra;
            cargoAFuturo += manager.GetComponent<Recursos>().cargoMaxCollectors / 10;
        }
        else
        {
            puntoCollectando = 0;
        }

    }
   

    void Depositar()
    {
        if (cargoActual > 0)
        {
            Vector2 direction = (deposito.transform.position + Vector3.up * Random.Range(6f, 7f)) - transform.position;
            transform.right = direction;
            GameObject obj = ObjectPool.SpawnObject(prefabPepitaProp, transform.position + Vector3.up, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(6, 7);
            obj.GetComponent<ReturnObj>().esPepitaProp = false;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up / 1.5f, 2);
            transform.rotation = Quaternion.Euler(Vector3.zero);
            manager.GetComponent<Recursos>().cantidadOro += manager.GetComponent<Recursos>().valorPiedra;
            cargoActual -= manager.GetComponent<Recursos>().pesoPiedra;
            Invoke(nameof(Depositar), speedCollectorRecolectar);
            Invoke(nameof(PopUp), 0.5f);
        }
        else if (truck.GetComponent<CamionDeCargo>().cantidad >= 1)
        {
            puntoDescargando = 0;
        }
        else
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
      
    }
    void PopUp()
    {
        GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + Vector3.up / 2, Quaternion.identity);
        popUp.GetComponentInChildren<TMP_Text>().text = "+" + manager.GetComponent<Recursos>().valorPiedra.ToString("F0");
    }
    private void OnDisable()
    {
        manager.GetComponent<Deposito>().cantidadAMandarCollectos -= 1;
        puntoMorir = 1;
    }
    
    void Update()
    {
        if(cargoActual <= 0)
        {
            cargoActual = 0;
        }
        if (esCollector && anularMovimiento <= 0)
        {
            if (cargoActual >= capacidadMax && puntoDescargando <= 0)
            {             
                if (GetComponent<SpriteRenderer>().flipX != true)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                }
                if (GetComponent<Animator>().GetBool("Caminar") == true)
                {
                    GetComponent<Animator>().SetBool("Caminar", false);
                }
                transform.position = Vector3.MoveTowards(transform.position, deposito.transform.position, speedCollector * Time.deltaTime);
            }
            else if (truck.GetComponent<CamionDeCargo>().cantidad >= 1 && cargoActual < capacidadMax && puntoDescargando <= 0 && puntoCollectando <= 0)
            {
                if (GetComponent<SpriteRenderer>().flipX != false)
                {
                    GetComponent<SpriteRenderer>().flipX = false;
                }
                if (GetComponent<Animator>().GetBool("Caminar") == true)
                {
                    GetComponent<Animator>().SetBool("Caminar", false);
                }
                transform.position = Vector3.MoveTowards(transform.position, truck.transform.position + Vector3.left / 3f, speedCollector * Time.deltaTime);
            }         
        }
        else if(esCollector)
        {
            if (GetComponent<SpriteRenderer>().flipX != true)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (GetComponent<Animator>().GetBool("Caminar") == true)
            {
                GetComponent<Animator>().SetBool("Caminar", false);
            }
            transform.position = Vector3.MoveTowards(transform.position, deposito.transform.position, speedCollector * Time.deltaTime);
        }
     
    
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CamionCargamento"))
        {
            if (puntoCollectando <= 0)
            {
                puntoCollectando = 1;
                Invoke(nameof(Recolectar), speedCollectorRecolectar);
            }
        }
        
        if (collision.CompareTag("DepositoCollectors"))
        {
            if (cargoActual > 0 && puntoDescargando <= 0)
            {
                cargoAFuturo = 0;
                puntoDescargando = 1;
                Invoke(nameof(Depositar), speedCollectorRecolectar);
            }
          
        }
    }
  
}
