using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PJ : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public static float Horizontal;
    private float Vertical;
    public float speed;


    public int puntoLimite;
    public GameObject cam;

   

    public GameObject posicionPrestigio;
    public GameObject limite;
    public GameObject limitePrestigio;
    public int puntoMirarEstrellas;
    public int puntoPrestigio;
    public int puntoPrestigioMoverCamara;

    public GameObject verEstrellas;
    public GameObject regresarAlCentro;
    public GameObject hoverVerEstrellas;
    public GameObject hoverRegresarAlCentro;

    public GameObject manager;

  
    public GameObject recuadroPrestigio;

    public GameObject observatorio;
    public GameObject deposito;
    public GameObject casa;
    public GameObject casa2;
    public GameObject casa3;
    public GameObject minero;
    public GameObject laboratorio;
    public GameObject truck;
    public GameObject iglesia;
    public GameObject suction;
    public GameObject park;
    public GameObject silo;
    public GameObject drill;

    public GameObject prefabParticulaDestruir;

    public GameObject particulasOro;
    public GameObject particulasFe;
    public GameObject particulasDworf;
    public GameObject particulasZafiro;
    public GameObject particulasEsmeralda;
    public GameObject particulasRubi;
    public GameObject particulasFlores;
    public GameObject particulasEstrellas;
    public GameObject particulasEstrellaGigante;

    public GameObject camara;



    public int puntoQuitarRecursos;
    public GameObject prestigio;

    private void Start()
    {
      //  puntoPrestigio = PlayerPrefs.GetInt("PuntoPrestigio");
      
    }
    private void OnApplicationQuit()
    {
        if (puntoPrestigio >= 1)
        {
            manager.GetComponent<Recursos>().cantidadOro = 0;
            manager.GetComponent<Recursos>().cantidadFe = 0;
            manager.GetComponent<Recursos>().cantidadZafiro = 0;
            manager.GetComponent<Recursos>().cantidadDworfsSinEmpleo = 2;
            puntoPrestigio = 0;
          //  PlayerPrefs.SetInt("PuntoPrestigio", puntoPrestigio);
        }
    }
    void Update()
    {
      //  PlayerPrefs.SetInt("PuntoPrestigio", puntoPrestigio);
       
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
       
    }
    void QuitarMovCamera()
    {
        manager.GetComponent<Recursos>().puntoMostrarRecuadroStarPoints = 1;
        particulasEstrellas.SetActive(false);
        particulasEstrellaGigante.SetActive(false);
        puntoPrestigioMoverCamara = 0;
        limitePrestigio.SetActive(true);
    }
    public void PrestigioReset()
    {
        puntoQuitarRecursos = 0;
        particulasOro.SetActive(false);
        particulasFe.SetActive(false);
        particulasDworf.SetActive(false);
        manager.GetComponent<Recursos>().cantidadOro = 0;
        manager.GetComponent<Recursos>().cantidadFe = 0;
        manager.GetComponent<Recursos>().cantidadZafiro = 0;
        manager.GetComponent<Recursos>().cantidadDworfsSinEmpleo = 2;
        camara.GetComponent<Zoom>().noEstaEnPestigio = 0;
        verEstrellas.SetActive(false);
        hoverVerEstrellas.SetActive(false);
        regresarAlCentro.SetActive(true);
        puntoPrestigioMoverCamara = 5;
        Invoke(nameof(QuitarMovCamera), 3.5f);
        limite.SetActive(false);
    }
    void QuitarPrestigioReset()
    {
    
        puntoPrestigio = 0;
        limitePrestigio.SetActive(true);
    }
    void MoverHaciaObservatorio()
    {
        camara.GetComponent<Zoom>().noEstaEnPestigio = 1;
        puntoPrestigioMoverCamara = 1;
    }
    void MoverHaciaDeposito()
    {
        puntoPrestigioMoverCamara = 2;
    }
    void MoverHaciaCasa()
    {
        puntoPrestigioMoverCamara = 3;
    }
    void MoverHaciaGeneral()
    {
        camara.GetComponent<Zoom>().noEstaEnPestigio = 0;
        camara.GetComponent<Zoom>().zoom = 9;
        puntoPrestigioMoverCamara = 4;
    }
    void ParticulaDestruirObservatorio()
    {
        observatorio.SetActive(false);
        ObjectPool.SpawnObject(prefabParticulaDestruir, observatorio.transform.position, Quaternion.identity);
    }
    void ParticulaDestruirDeposito()
    {
        deposito.SetActive(false);
        ObjectPool.SpawnObject(prefabParticulaDestruir, deposito.transform.position, Quaternion.identity);
    }
    void ParticulaDestruirCasa()
    {
        casa.SetActive(false);
        ObjectPool.SpawnObject(prefabParticulaDestruir, casa.transform.position, Quaternion.identity);
    }
    void QuitarPuntoPrestigio()
    {
        puntoPrestigio = 1;
    }
    void ParticulaDestruirEnGeneral()
    {
        puntoQuitarRecursos = 1;
        Invoke(nameof(QuitarPuntoPrestigio), 1);
        particulasOro.SetActive(true);
        particulasFe.SetActive(true);
        particulasDworf.SetActive(true);
     
        if (manager.GetComponent<Construir>().puntoCasa2Cosntruida >= 1)
        {
            casa2.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, casa2.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoCasa3Cosntruida >= 1)
        {
            casa3.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, casa3.transform.position, Quaternion.identity);

        }
        if (manager.GetComponent<Construir>().puntoCasaMinerosConstruida >= 1)
        {
            minero.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, minero.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoCatedralCosntruida >= 1)
        {
            iglesia.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, iglesia.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoLaboratorioCosntruida >= 1)
        {
            laboratorio.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, laboratorio.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoSuctionMachineCosntruida >= 1)
        {
            suction.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, suction.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoDrillsCosntruida >= 1)
        {
            drill.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, suction.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<Construir>().puntoRocketCosntruida >= 1)
        {
            silo.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, silo.transform.position, Quaternion.identity);
        }
        if (manager.GetComponent<MejorasPrestigio>().nivelMejoraParqueAtraccion >= 1)
        {
            park.SetActive(false);
            ObjectPool.SpawnObject(prefabParticulaDestruir, park.transform.position, Quaternion.identity);
        }
        ObjectPool.SpawnObject(prefabParticulaDestruir, drill.transform.position, Quaternion.identity);
    }
    void ActivarEstrellas()
    {
        particulasEstrellas.SetActive(true);
    }
    void ActivarEstrellaGigante()
    {
        particulasEstrellaGigante.SetActive(true);
        Invoke(nameof(ObtenerStarPoint), 3.5f);
    }
    void ObtenerStarPoint()
    {
        manager.GetComponent<Recursos>().cantidadStarPoints += manager.GetComponent<Recursos>().cantidadStarPointsAlPrestigear;
        manager.GetComponent<Recursos>().cantidadReqParaStarPoint = 1000;
        manager.GetComponent<Recursos>().cantidadStarPointsAlPrestigear = 0;
     
    }
    public void PuntoPrestigio()
    {

        camara.GetComponent<Zoom>().zoom = 2f;

        verEstrellas.SetActive(false);
        regresarAlCentro.SetActive(true);
        limite.SetActive(false);
        recuadroPrestigio.SetActive(false);



        puntoPrestigio = 1;
        Invoke(nameof(MoverHaciaObservatorio), 1f);
        Invoke(nameof(ParticulaDestruirObservatorio), 2.25f);
        Invoke(nameof(MoverHaciaDeposito), 3f);
        Invoke(nameof(ParticulaDestruirDeposito), 4.25f);
        Invoke(nameof(MoverHaciaCasa), 5f);
        Invoke(nameof(ParticulaDestruirCasa), 6.25f);
        Invoke(nameof(MoverHaciaGeneral), 7f);
        Invoke(nameof(ParticulaDestruirEnGeneral), 8.25f);
        Invoke(nameof(ActivarEstrellas), 9);
        Invoke(nameof(ActivarEstrellaGigante), 14);
        Invoke(nameof(PrestigioReset), 13.5f);


        manager.GetComponent<Menus>().puntoPrestigioDesSeleccionarPociones = 1;




        //set back pociones
        manager.GetComponent<Menus>().pocionDworf.GetComponent<Image>().sprite = manager.GetComponent<Menus>().pocionDworfDesSeleccionada;
        manager.GetComponent<Menus>().puntoDworfSeleccionada = 0;
        manager.GetComponent<Menus>().pocionHardness.GetComponent<Image>().sprite = manager.GetComponent<Menus>().pocionHardnessDesSeleccionada;
        manager.GetComponent<Menus>().puntoHardnessSeleccionada = 0;
        manager.GetComponent<Menus>().pocionRGB.GetComponent<Image>().sprite = manager.GetComponent<Menus>().pocionRGBDesSeleccionada;
        manager.GetComponent<Menus>().puntoRGBSeleccionada = 0;
    

        //recursos y piedra
        manager.GetComponent<Recursos>().valorDworfsFe = 1;
        manager.GetComponent<Recursos>().cantidadPepitasMax = 600;     
       manager.GetComponent<Recursos>().pesoPiedra = 1;
        manager.GetComponent<Recursos>().vidaMaxPiedra = 1;
        manager.GetComponent<Recursos>().valorZafiro = 1;
        manager.GetComponent<Recursos>().vidaMaxZafiro = 10000;
        if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
        {
            manager.GetComponent<Recursos>().valorPiedra = 1;
            for (int i = 0; i < prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor; i++)
            {
                manager.GetComponent<Recursos>().valorPiedra *= 1.5f;
            }
        }
        else
        {
            manager.GetComponent<Recursos>().valorPiedra = 1;
        }
        manager.GetComponent<Recursos>().cantidadDworfsMinerosEnPantalla = 0;
        manager.GetComponent<Recursos>().cantidadDrillsEnPantalla = 0;
        manager.GetComponent<Recursos>().cantidadDworfsAlquimistasEnPantalla = 0;


     



        //Clicks
        manager.GetComponent<Recursos>().dañoClick = 1;
        manager.GetComponent<Recursos>().dañoCrit = 2;
        if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasProbClickCrit >= 1)
        {
            manager.GetComponent<Recursos>().probCrit = 2 * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasProbClickCrit;
        }
        else
        {
            manager.GetComponent<Recursos>().probCrit = 0;
        }

        //Suction Machine
        manager.GetComponent<Recursos>().cantidadASuccionar = 5;
        manager.GetComponent<Recursos>().timeRecharge = 3;
        manager.GetComponent<Recursos>().timeSuccion = 0.75f;

        //Truck
        manager.GetComponent<Recursos>().cargoMaxCamion = 20;

        //collectors
        manager.GetComponent<Recursos>().speedCollectors = 2;
        manager.GetComponent<Recursos>().speedCollectorsRecolectar = 1;
        manager.GetComponent<Recursos>().cargoMaxCollectors = 10;

        //miners
        manager.GetComponent<Recursos>().dañoDworfsMineros = 1;
        manager.GetComponent<Recursos>().speedAtaqueMiners = 2;
        manager.GetComponent<Recursos>().speedMiners = 2;
        manager.GetComponent<Recursos>().sleepMiners = 13;
        manager.GetComponent<Recursos>().energiaMiners = 30;

        //alquimistas

        //construcciones
        manager.GetComponent<Construir>().puntoCasa2Cosntruida = 0;
        manager.GetComponent<Construir>().puntoCasa3Cosntruida = 0;
        manager.GetComponent<Construir>().puntoCasaMinerosConstruida = 0;
        manager.GetComponent<Construir>().puntoCatedralCosntruida = 0;
        manager.GetComponent<Construir>().puntoLaboratorioCosntruida = 0;
        manager.GetComponent<Construir>().puntoObservatorioCosntruida = 0;
        manager.GetComponent<Construir>().puntoSuctionMachineCosntruida = 0;

        //reset niveles y costos
        manager.GetComponent<MejorasCasa>().nivelMejoraConvertirEnObeliscoCasa1 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraConvertirEnObeliscoCasa2 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraConvertirEnObeliscoCasa3 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraObelisco1Daño = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraObelisco2Daño = 0;
        manager.GetComponent<MejorasCasa>().nivelMejoraObelisco3Daño = 0;
        manager.GetComponent<MejorasCasa>().costeOroMejoraConvertirEnObeliscoCasa1 = 500;
        manager.GetComponent<MejorasCasa>().costeOroMejoraConvertirEnObeliscoCasa2 = 35000;
        manager.GetComponent<MejorasCasa>().costeOroMejoraConvertirEnObeliscoCasa3 = 300000;
        manager.GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa1 = 10;
        manager.GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa2 = 750;
        manager.GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa3 = 6000;
        manager.GetComponent<MejorasCasa>().costeOroMejoraObelisco1Daño = 750;
        manager.GetComponent<MejorasCasa>().costeOroMejoraObelisco2Daño = 50000;
        manager.GetComponent<MejorasCasa>().costeOroMejoraObelisco3Daño = 400000;
        manager.GetComponent<MejorasCatedral>().nivelFeMejoraMasDañoClick = 0;
        manager.GetComponent<MejorasCatedral>().nivelFeMejoraMasDañoDworfs = 0;
        manager.GetComponent<MejorasCatedral>().nivelFeMejoraMasValorOro = 0;
        manager.GetComponent<MejorasCatedral>().nivelMejoraMasDañoClick = 0;
        manager.GetComponent<MejorasCatedral>().nivelMejoraMasDañoCrit = 0;
        manager.GetComponent<MejorasCatedral>().nivelMejoraMasFe = 0;
        manager.GetComponent<MejorasCatedral>().nivelMejoraMasProbCritClick = 0;
        manager.GetComponent<MejorasCatedral>().costeFeMejoraMasDañoClick = 100;
        manager.GetComponent<MejorasCatedral>().costeFeMejoraMasDañoDworfs = 150;
        manager.GetComponent<MejorasCatedral>().costeFeMejoraMasValorOro = 200;
        manager.GetComponent<MejorasCatedral>().costeOroMejoraMasDañoClick = 25;
        manager.GetComponent<MejorasCatedral>().costeOroMejoraMasDañoCrit = 50;
        manager.GetComponent<MejorasCatedral>().costeOroMejoraMasFe = 100;
        manager.GetComponent<MejorasCatedral>().costeOroMejoraMasProbCritClick = 50;
        manager.GetComponent<MejorasDeposito>().nivelMejoraMasCapacidad = 0;
        manager.GetComponent<MejorasDeposito>().nivelMejoraMasCollectors = 0;
        manager.GetComponent<MejorasDeposito>().nivelMejoraMasVelocidad = 0;
        manager.GetComponent<MejorasDeposito>().costeOroMejoraMasCapacidad = 10;
        manager.GetComponent<MejorasDeposito>().costeOroMejoraMasCollectors = 0;
        manager.GetComponent<MejorasDeposito>().costeOroMejoraMasVelocidad = 5;
        manager.GetComponent<MejorasLaboratorio>().nivelMejoraMasAlquimistas = 0;
        manager.GetComponent<MejorasLaboratorio>().nivelMejoraMasHardness = 0;
        manager.GetComponent<MejorasLaboratorio>().nivelMejoraPocionDworfs = 0;
        manager.GetComponent<MejorasLaboratorio>().nivelMejoraPocionHardness = 0;
        manager.GetComponent<MejorasLaboratorio>().costeOroMejoraHardness = 100;
        manager.GetComponent<MejorasLaboratorio>().costeOroMejoraMasAlquimistas = 150;
        manager.GetComponent<MejorasLaboratorio>().costeZafiroMejoraPocionDworfs = 50;
        manager.GetComponent<MejorasLaboratorio>().costeZafiroMejoraPocionHardness = 100;
        manager.GetComponent<MejorasMineros>().nivelMejoraMasMiners = 0;
        manager.GetComponent<MejorasMineros>().nivelMejoraMinersMasDaño = 0;
        manager.GetComponent<MejorasMineros>().nivelMejoraMinersMasEnergia = 0;
        manager.GetComponent<MejorasMineros>().nivelMejoraMinersMasVelocidad = 0;
        manager.GetComponent<MejorasMineros>().nivelMejoraMinersMenosSleep = 0;
        manager.GetComponent<MejorasMineros>().costeOroMejoraMasMiners = 25;
        manager.GetComponent<MejorasMineros>().costeOroMejoraMinersMasDaño = 75;
        manager.GetComponent<MejorasMineros>().costeOroMejoraMinersMasEnergia = 100;
        manager.GetComponent<MejorasMineros>().costeOroMejoraMinersMasVelocidad = 75;
        manager.GetComponent<MejorasMineros>().costeOroMejoraMinersMenosSleep = 100;
        manager.GetComponent<MejorasSuction>().nivelMejoraMasSpeed = 0;
        manager.GetComponent<MejorasSuction>().nivelMejoraMasSuccionados = 0;
        manager.GetComponent<MejorasSuction>().nivelMejoraMenosRecharge = 0;
        manager.GetComponent<MejorasSuction>().costeOroMejoraMasSpeed = 10;
        manager.GetComponent<MejorasSuction>().costeOroMejoraMasSuccionados = 50;
        manager.GetComponent<MejorasSuction>().costeOroMejoraMenosRecharge = 10;
        manager.GetComponent<MejorasTruck>().nivelMejoraMasCapacidad = 0;
        manager.GetComponent<MejorasTruck>().nivelMejoraMasVelocidad = 0;
        manager.GetComponent<MejorasTruck>().costeOroMejoraMasCapacidad = 5;
        manager.GetComponent<MejorasTruck>().costeOroMejoraMasVelocidad = 5;

        //reset dworfs
        manager.GetComponent<Recursos>().cantidadDworfsCollectors = 0;
        manager.GetComponent<Recursos>().cantidadDworfsMineros = 0;
        manager.GetComponent<Recursos>().cantidadDrills = 0;
        manager.GetComponent<Recursos>().cantidadTotalDworfs = 2;

        Invoke(nameof(SetearA0CantidadPepitasEnFozo), 1f);




    }
    void SetearA0CantidadPepitasEnFozo()
    {
        manager.GetComponent<Recursos>().cantidadPepitasEnSuelo = 0;
        manager.GetComponent<Recursos>().cantidadPepitasActual = 0;
    }
    public void Prestigio()
    {
        AudioManager.instance.PlaySFX("Click");
        verEstrellas.SetActive(false);
        hoverVerEstrellas.SetActive(false);
        regresarAlCentro.SetActive(true);
        puntoMirarEstrellas = 1;
        Invoke(nameof(QuitarPrestigio), 1.5f);
        limite.SetActive(false);
    }
    void QuitarPrestigio()
    {
        puntoMirarEstrellas = 0;
        limitePrestigio.SetActive(true);
    }
    public void VolverAlCentro()
    {
        AudioManager.instance.PlaySFX("Click");
        verEstrellas.SetActive(true);
        hoverRegresarAlCentro.SetActive(false);
        regresarAlCentro.SetActive(false);
        puntoMirarEstrellas = 2;
        Invoke(nameof(VolverAlCentroPonerLimite), 1.5f);
        limitePrestigio.SetActive(false);
    }
    void VolverAlCentroPonerLimite()
    {
        puntoMirarEstrellas = 0;
        limite.SetActive(true);
    }
 
    private void FixedUpdate()
    {
        if (puntoQuitarRecursos >= 1)
        {
            if (manager.GetComponent<Recursos>().cantidadDworfsSinEmpleo >= 3)
            {
                manager.GetComponent<Recursos>().cantidadDworfsSinEmpleo -= 1;
            }
            if (manager.GetComponent<Recursos>().cantidadOro >= 1)
            {
                manager.GetComponent<Recursos>().cantidadOro /= 1.05f;
            }
            if (manager.GetComponent<Recursos>().cantidadFe >= 1)
            {
                manager.GetComponent<Recursos>().cantidadFe /= 1.05f;
            }
         
         
        }
        if (puntoPrestigioMoverCamara <= 0)
        {
            Rigidbody2D.velocity = new Vector2(Horizontal * speed, Rigidbody2D.velocity.y);
            Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, Vertical * speed);
        }
        if (puntoLimite >= 1)
        {
            transform.position = new Vector3(0, -1, 0);
        }


        if (puntoMirarEstrellas == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionPrestigio.transform.position, 55);
        }
        if (puntoMirarEstrellas >= 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,0), 55);
        }      
        if (puntoPrestigioMoverCamara == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, observatorio.transform.position, 10);
        }
       else if (puntoPrestigioMoverCamara == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, deposito.transform.position, 15);
        }
        else if (puntoPrestigioMoverCamara == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, casa.transform.position, 5);
        }
        else if (puntoPrestigioMoverCamara == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-18,-2.5f,0), 8);
        }
        else if (puntoPrestigioMoverCamara == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionPrestigio.transform.position, 1);
        }
    }
    void QuitarPuntoLimite()
    {
        puntoLimite = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limite"))
        {
            puntoLimite = 1;
            Invoke(nameof(QuitarPuntoLimite), 1f);
            transform.position = new Vector3(0, -1, 0);
        }
        if (collision.CompareTag("ColliderSonidoPiedra"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoPiedra = 1;
        }
        if (collision.CompareTag("ColliderSonidoCentro"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoCentro = 1;
        }
        if (collision.CompareTag("ColliderSonidoZafiroYTal"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoZafiroYTal = 1;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ColliderSonidoPiedra"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoPiedra = 0;
        }
        if (collision.CompareTag("ColliderSonidoCentro"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoCentro = 0;
        }
        if (collision.CompareTag("ColliderSonidoZafiroYTal"))
        {
            manager.GetComponent<Recursos>().puntoColliderSonidoZafiroYTal = 0;
        }
    }

}
