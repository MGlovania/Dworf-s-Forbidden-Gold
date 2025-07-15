using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodos : MonoBehaviour
{
    [SerializeField] private Transform[] nodoValor_casa;
    [SerializeField] private Transform[] nodoValor_park;
    [SerializeField] private Transform[] nodoValor_click;
    [SerializeField] private Transform[] nodoValor_Zafiro;
    [SerializeField] private LineController lineaValor;
    [SerializeField] private LineController lineaValor2;
    [SerializeField] private LineController lineaValor3;
    [SerializeField] private LineController lineaValor4;

    [SerializeField] private Transform[] nodoClick_probCrit;
    [SerializeField] private Transform[] nodoClick_dañoCrit;
    [SerializeField] private LineController lineaClick;
    [SerializeField] private LineController lineaClick2;

    [SerializeField] private Transform[] nodoPark_masFe;
    [SerializeField] private Transform[] nodoPark_masSP;
    [SerializeField] private LineController lineaPark;
    [SerializeField] private LineController lineaPark2;

    [SerializeField] private Transform[] nodoCasa_succion;
    [SerializeField] private LineController lineaCasa;

    [SerializeField] private Transform[] nodoSuccion_masSuccion;
    [SerializeField] private Transform[] nodoSuccion_truck;
    [SerializeField] private LineController lineaSuccion;
    [SerializeField] private LineController lineaSuccion2;

    [SerializeField] private Transform[] nodoTruck_collector;
    [SerializeField] private LineController lineaTruck;

    [SerializeField] private Transform[] nodoCollector_minero;
    [SerializeField] private LineController lineaCollector;

    [SerializeField] private Transform[] nodoMinero_picoRainbow;
    [SerializeField] private Transform[] nodoMinero_Zafiro;
    [SerializeField] private LineController lineaMinero;
    [SerializeField] private LineController lineaMinero2;

    [SerializeField] private Transform[] nodoZafiro_pocionRGB;
    [SerializeField] private LineController lineaZafiro;


    public GameObject desbloqClick_Casa_Park_Zafiro;
    public GameObject desbloqCritProb_CritDamage;
    public GameObject desbloqMasFe_MasSP;
    public GameObject desbloqVelocidadSuccion;
    public GameObject desbloqMasSuccion_MasCapacityTruck;
    public GameObject desbloqCollectors;
    public GameObject desbloqMineros;
    public GameObject desbloqPicosRainbow;
    public GameObject desbloqPocionRGB;
    void Start()
    {
        Invoke(nameof(VerifNodos), 1f);

     
       
     
    }
    void VerifNodos()
    {
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
        {
            desbloqClick_Casa_Park_Zafiro.SetActive(true);
            lineaValor.SetUpLine(nodoValor_casa);
            lineaValor2.SetUpLine(nodoValor_park);
            lineaValor3.SetUpLine(nodoValor_click);
            lineaValor4.SetUpLine(nodoValor_Zafiro);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick >= 1)
        {
            desbloqCritProb_CritDamage.SetActive(true);
            lineaClick.SetUpLine(nodoClick_probCrit);
            lineaClick2.SetUpLine(nodoClick_dañoCrit);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraParqueAtraccion >= 1)
        {
            desbloqMasFe_MasSP.SetActive(true);
            lineaPark.SetUpLine(nodoPark_masFe);
            lineaPark2.SetUpLine(nodoPark_masSP);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasDworfsCasa >= 1)
        {
            desbloqVelocidadSuccion.SetActive(true);
            lineaCasa.SetUpLine(nodoCasa_succion);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraSpeedSuccion >= 1)
        {
            desbloqMasSuccion_MasCapacityTruck.SetActive(true);
            lineaSuccion.SetUpLine(nodoSuccion_masSuccion);
            lineaSuccion2.SetUpLine(nodoSuccion_truck);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasCargoCollectors >= 1)
        {
            desbloqCollectors.SetActive(true);
            lineaTruck.SetUpLine(nodoTruck_collector);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasCargoTruck >= 1)
        {
            desbloqMineros.SetActive(true);
            lineaCollector.SetUpLine(nodoCollector_minero);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraMasDañoMineros >= 1)
        {
            desbloqPicosRainbow.SetActive(true);
            lineaMinero.SetUpLine(nodoMinero_picoRainbow);
            lineaMinero2.SetUpLine(nodoMinero_Zafiro);
        }
        if (GetComponent<MejorasPrestigio>().nivelMejoraDesbloqZafiro >= 1)
        {
            desbloqPocionRGB.SetActive(true);
            lineaZafiro.SetUpLine(nodoZafiro_pocionRGB);
        }

    }
    public void SetLineaValor()
    {
        desbloqClick_Casa_Park_Zafiro.SetActive(true);
        lineaValor.SetUpLine(nodoValor_casa);
        lineaValor2.SetUpLine(nodoValor_park);
        lineaValor3.SetUpLine(nodoValor_click);
        lineaValor4.SetUpLine(nodoValor_Zafiro);

    }
    public void SetLineaClickDamage()
    {
        desbloqCritProb_CritDamage.SetActive(true);
        lineaClick.SetUpLine(nodoClick_probCrit);
        lineaClick2.SetUpLine(nodoClick_dañoCrit);
    }
    public void SetLineaPark()
    {
        desbloqMasFe_MasSP.SetActive(true);
        lineaPark.SetUpLine(nodoPark_masFe);
        lineaPark2.SetUpLine(nodoPark_masSP);
    }
    public void SetLineaCasa()
    {
        desbloqVelocidadSuccion.SetActive(true);
        lineaCasa.SetUpLine(nodoCasa_succion);
    }
    public void SetLineaSuctionSpeed()
    {
        desbloqMasSuccion_MasCapacityTruck.SetActive(true);
        lineaSuccion.SetUpLine(nodoSuccion_masSuccion);
        lineaSuccion2.SetUpLine(nodoSuccion_truck);
    }
    public void SetLineaTruck()
    {
        desbloqCollectors.SetActive(true);
        lineaTruck.SetUpLine(nodoTruck_collector);
    }
    public void SetLineaCollectors()
    {
        desbloqMineros.SetActive(true);
        lineaCollector.SetUpLine(nodoCollector_minero);
    }
    public void SetLineaMineros()
    {
        desbloqPicosRainbow.SetActive(true);
        lineaMinero.SetUpLine(nodoMinero_picoRainbow);
        lineaMinero2.SetUpLine(nodoMinero_Zafiro);
    }
    public void SetLineaZafiro()
    {
        desbloqPocionRGB.SetActive(true);
        lineaZafiro.SetUpLine(nodoZafiro_pocionRGB);
    }


    void Update()
    {

    }

}
