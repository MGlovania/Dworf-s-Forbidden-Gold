using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CamionDeCargo : MonoBehaviour
{
    public TMP_Text cantidadActualDePepitasText;
    public TMP_Text cantidadActualDePepitasMaxText;
  

    public double cantidad;
    public double cantidadMax;
    public GameObject target;
    public GameObject posicionTruck;
    public float speed;
    public int volverADeposito;
    public int colisionConDesposito;
    public int volverAMina;
    public int collectorsQuitar;
    public GameObject cargamento;
    public GameObject manager;
    public GameObject recuadroTutorial;
    public GameObject recuadroTutorial2;

    public int puntoSfxTruck;
    void Start()
    {
        cantidad = 0;
        collectorsQuitar = 1;
        cantidadMax = manager.GetComponent<Recursos>().cargoMaxCamion;
        speed = PlayerPrefs.GetFloat("SpeedTruck");
        if (speed <= 0)
        {
            speed = 1.45f;
        }
        Invoke(nameof(Verif), 0.25f);
    }
    void Verif()
    {
        cantidadMax = manager.GetComponent<Recursos>().cargoMaxCamion;
        if (cantidad < cantidadMax / 2)
        {
            cargamento.SetActive(false);
        }
        Invoke(nameof(Verif), 0.25f);
        if(cantidad <= 0 && colisionConDesposito >= 1)
        {
            colisionConDesposito = 0;
            GetComponent<Animator>().SetBool("Deposito", true);
            volverAMina = 1;
            collectorsQuitar = 1;
           
           
        }
        if (cantidad >= cantidadMax && colisionConDesposito <= 0)
        {
            manager.GetComponent<Recursos>().permitirSuccion = 0;
            cargamento.SetActive(true);
                volverADeposito = 1;
                volverAMina = 0;
                GetComponent<Animator>().SetBool("Deposito", true);           
      
        }
        if (volverADeposito >= 1 && puntoSfxTruck <= 0)
        {
            puntoSfxTruck = 1;
            Invoke(nameof(Sonido), 0.15f);
        }
        if (cantidad <= 0 && volverAMina >= 1)
        {
            Invoke(nameof(Sonido), 0.15f);
        }
    }
    void Sonido()
    {
        if (volverADeposito >= 1)
        {
            if (manager.GetComponent<Recursos>().puntoColliderSonidoZafiroYTal >= 1)
            {
                AudioManager.instance.PlaySFX("TruckSfx");
            }
            Invoke(nameof(Sonido), 0.15f);
        }
    }
   
    void Update()
    {
        PlayerPrefs.SetFloat("SpeedTruck", speed);

      
        if (cantidad <= 0)
        {
            cantidad = 0;
        }
     
        cantidadActualDePepitasText.text = cantidad.ToString("F0");
        cantidadActualDePepitasMaxText.text = "/" + cantidadMax.ToString("F0");
      
        if (volverADeposito >= 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.left, speed * Time.deltaTime);
        }  
        else if (volverAMina >= 1 && cantidad <= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionTruck.transform.position, (speed / 1.2f) * Time.deltaTime);
        }
    }
    void RecuadroTutorial2()
    {
        if (manager.GetComponent<Intro>().puntoTruckDeVueltaEnMinaIntro <= 0)
        {
            manager.GetComponent<Intro>().puntoTruckDeVueltaEnMinaIntro = 1;
            recuadroTutorial2.SetActive(true);
            PlayerPrefs.SetInt("PuntoTruckDeVueltaEnMinaIntro", manager.GetComponent<Intro>().puntoTruckDeVueltaEnMinaIntro);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deposito"))
        {
            puntoSfxTruck = 0;
            collectorsQuitar = 0;
            GetComponent<Animator>().SetBool("Deposito", false);
            volverADeposito = 0;
            colisionConDesposito = 1;
            manager.GetComponent<Deposito>().puntoCamionColision = 1;
            if (manager.GetComponent<Intro>().puntoTruckEnDepositoIntro <= 0)
            {
                manager.GetComponent<Intro>().puntoTruckEnDepositoIntro = 1;
                recuadroTutorial.SetActive(true);
                PlayerPrefs.SetInt("PuntoTruckEnDepositoIntro", manager.GetComponent<Intro>().puntoTruckEnDepositoIntro);
                Invoke(nameof(RecuadroTutorial2),22f);
            }
            
        }
        if (collision.CompareTag("PosicionTruck"))
        {
            manager.GetComponent<Deposito>().cantidadAMandarCollectos = 0;
            manager.GetComponent<Recursos>().permitirSuccion = 1;
            GetComponent<Animator>().SetBool("Deposito", false);
            volverAMina = 0;
        }
    }
}
