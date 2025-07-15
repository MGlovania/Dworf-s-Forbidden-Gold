using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menus : MonoBehaviour
{

    public GameObject recuadroDeposito;
    public GameObject recuadroDepositoTutorialQuitar;
    public int puntoDeposito;

    public GameObject recuadroSuccion;
    public int puntoSuccion;

    public GameObject recuadroMiners;
    public int puntoMiners;

    public GameObject recuadroTruck;
    public int puntoTruck;

    public GameObject recuadroCasa1;
    public GameObject posicionCasa1;
    public int puntoCasa1;
    public GameObject recuadroObelisco1;

    public GameObject recuadroCasa2;
    public GameObject posicionCasa2;
    public int puntoCasa2;
    public GameObject recuadroObelisco2;

    public GameObject recuadroCasa3;
    public GameObject posicionCasa3;
    public int puntoCasa3;
    public GameObject recuadroObelisco3;

    public GameObject recuadroIglesia;
    public int puntoIglesia;

    public GameObject recuadroLaboratorio;
    public GameObject recuadroLaboratorio2;
    public int puntoLaboratorio;
    public GameObject botonMenuLaboratorio1;
    public GameObject botonMenuLaboratorio2;
    public GameObject pocionRGBBloq;
    public GameObject pocionRGBPoner;


    public GameObject recuadroDrillGlobal;
    public GameObject recuadroDrill;
    public GameObject recuadroDrill2;
    public int puntoDrill;
    public GameObject botonMenuDrill1;
    public GameObject botonMenuDrill2;
    public GameObject botonCambiarRoca;
    public GameObject mostrarCambiarRoca;
    public int puntoRecuadroMostrarCambiarRoca;
    public Sprite gold;
    public Sprite zafiro;
    public int puntoPiedraGoldSeleccionada;
    public int puntoPiedraZafiroSeleccionada;

    public GameObject recuadroAlquimistasSeleccionarPiedra;
    public int puntoAlquimistasSeleccionarPiedra;



    public Image pocionDworf;
    public Image pocionHardness;
    public Image pocionRGB;
    public Sprite pocionDworfDesSeleccionada;
    public Sprite pocionHardnessDesSeleccionada;
    public Sprite pocionRGBDesSeleccionada;
    public Sprite pocionDworfSeleccionada;
    public Sprite pocionHardnessSeleccionada;
    public Sprite pocionRGBSeleccionada;
    public int puntoDworfSeleccionada;
    public int puntoHardnessSeleccionada;
    public int puntoRGBSeleccionada;

    public GameObject recuadroObservatorio;
    public int puntoObservatorio;

    public GameObject recuadroPark;
    public int puntoPark;

    public GameObject recuadroSilo;
    public int puntoSilo;

    public GameObject player;
    public int puntoPrestigioDesSeleccionarPociones;


    public GameObject menuInfo;
    public GameObject menuInfoRecursos;
    public GameObject menuInfoClicks;
    public GameObject menuInfoUnemployed;
    public GameObject menuInfoCollectors;
    public GameObject menuInfoRangedMiners;
    public GameObject menuInfoPowerDrills;
    public GameObject menuInfoAlchemists;

    public int puntoMenuInfo;

    public GameObject menuOpciones;
    public int puntoMenuOpciones;

    public GameObject menuOpcionesIntro;
    public int puntoMenuOpcionesIntro;

    public GameObject prestigio;

    public int puntoVolverAActivarBoton;
    void Start()
    {

        puntoObservatorio = PlayerPrefs.GetInt("PuntoObservatorio");

        puntoHardnessSeleccionada = PlayerPrefs.GetInt("PuntoHardnessSeleccionada");
        puntoRGBSeleccionada = PlayerPrefs.GetInt("PuntoRGBSeleccionada");
        puntoDworfSeleccionada = PlayerPrefs.GetInt("PuntoDworfSeleccionada");

        puntoPiedraGoldSeleccionada = PlayerPrefs.GetInt("PuntoPiedraGoldSeleccionada");
        puntoPiedraZafiroSeleccionada = PlayerPrefs.GetInt("PuntoPiedraZafiroSeleccionada");
        if (puntoPiedraGoldSeleccionada >= 1)
        {
            botonCambiarRoca.GetComponent<Image>().sprite = gold;
        }
        if (puntoPiedraZafiroSeleccionada >= 1)
        {
            botonCambiarRoca.GetComponent<Image>().sprite = zafiro;
        }

        if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraDesbloqRGBPotion >= 0)
        {
            pocionRGBBloq.SetActive(false);
            pocionRGBPoner.SetActive(true);
        }


        if (puntoDworfSeleccionada >= 1)
        {
            pocionDworf.GetComponent<Image>().sprite = pocionDworfSeleccionada;
        }
        else if (puntoHardnessSeleccionada >= 1)
        {
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessSeleccionada;
        }
        else if (puntoRGBSeleccionada >= 1)
        {
            pocionRGB.GetComponent<Image>().sprite = pocionRGBSeleccionada;
        }
     
    }
   
    private void Update()
    {

        PlayerPrefs.SetInt("PuntoObservatorio", puntoObservatorio);


        PlayerPrefs.SetInt("PuntoDworfSeleccionada", puntoDworfSeleccionada);
        PlayerPrefs.SetInt("PuntoHardnessSeleccionada", puntoHardnessSeleccionada);
        PlayerPrefs.SetInt("PuntoRGBSeleccionada", puntoRGBSeleccionada);

        PlayerPrefs.SetInt("PuntoPiedraGoldSeleccionada", puntoPiedraGoldSeleccionada);
        PlayerPrefs.SetInt("PuntoPiedraZafiroSeleccionada", puntoPiedraZafiroSeleccionada);

    }
    public void MenuOpciones()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoMenuOpciones <= 0)
        {
            menuOpciones.SetActive(true);
            puntoMenuOpciones = 1;
        }
        else
        {
            menuOpciones.SetActive(false);
            puntoMenuOpciones = 0;
        }

    }
    public void MenuOpcionesIntro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoMenuOpcionesIntro <= 0)
        {
            menuOpcionesIntro.SetActive(true);
            puntoMenuOpcionesIntro = 1;
        }
        else
        {
            menuOpcionesIntro.SetActive(false);
            puntoMenuOpcionesIntro = 0;
        }

    }
    public void MenuInfo()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoMenuInfo <= 0)
        {
            menuInfo.SetActive(true);
            puntoMenuInfo = 1;
        }
        else
        {
            menuInfo.SetActive(false);
            puntoMenuInfo = 0;
        }
    }
    public void MenuInfoRecursos()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(true);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoClicks()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(true);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoUnemployed()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(true);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoCollectors()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(true);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoMiners()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(true);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoPowerDrills()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(true);
        menuInfoAlchemists.SetActive(false);
    }
    public void MenuInfoAlchemists()
    {
        AudioManager.instance.PlaySFX("Click");
        menuInfoRecursos.SetActive(false);
        menuInfoClicks.SetActive(false);
        menuInfoUnemployed.SetActive(false);
        menuInfoCollectors.SetActive(false);
        menuInfoRangedMiners.SetActive(false);
        menuInfoPowerDrills.SetActive(false);
        menuInfoAlchemists.SetActive(true);
    }
    public void ActualizarAlquimistas()
    {
        if (puntoDworfSeleccionada >= 1)
        {
            for (int i = 0; i < GetComponent<Recursos>().cantidadDworfsAlquimistas; i++)
            {
                GetComponent<Recursos>().valorDworfsFe /= GetComponent<Recursos>().buffoAlquimistasDworfs;
            }
        }
        if (puntoHardnessSeleccionada >= 1)
        {
            for (int i = 0; i < GetComponent<Recursos>().cantidadDworfsAlquimistas; i++)
            {
                GetComponent<Recursos>().valorPiedra /= GetComponent<Recursos>().buffoAlquimistasHardness;
            }
        }


    }
    public void PocionDworf()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoDworfSeleccionada <= 0)
        {
            for (int i = 0; i < GetComponent<Recursos>().cantidadDworfsAlquimistas; i++)
            {
                GetComponent<Recursos>().valorDworfsFe *= GetComponent<Recursos>().buffoAlquimistasDworfs;
            }
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            pocionDworf.GetComponent<Image>().sprite = pocionDworfSeleccionada;
            puntoDworfSeleccionada = 1;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;

        }
        else
        {
            pocionDworf.GetComponent<Image>().sprite = pocionDworfDesSeleccionada;
            puntoDworfSeleccionada = 0;
        }
    }
    public void PocionHardness()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoHardnessSeleccionada <= 0)
        {
            for (int i = 0; i < GetComponent<Recursos>().cantidadDworfsAlquimistas; i++)
            {
                GetComponent<Recursos>().valorPiedra *= GetComponent<Recursos>().buffoAlquimistasHardness;
            }

            pocionHardness.GetComponent<Image>().sprite = pocionHardnessSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            pocionDworf.GetComponent<Image>().sprite = pocionDworfDesSeleccionada;
            puntoDworfSeleccionada = 0;
            puntoHardnessSeleccionada = 1;
            puntoRGBSeleccionada = 0;

        }
        else
        {
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            puntoHardnessSeleccionada = 0;
        }
    }
    public void PocionRGB()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoRGBSeleccionada <= 0)
        {
            for (int i = 0; i < GetComponent<Recursos>().cantidadDworfsAlquimistas; i++)
            {
                GetComponent<Recursos>().valorZafiro *= GetComponent<Recursos>().buffoAlquimistasRGB;
            }
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBSeleccionada;
            pocionDworf.GetComponent<Image>().sprite = pocionDworfDesSeleccionada;
            puntoDworfSeleccionada = 0;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 1;
        }
        else
        {
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoRGBSeleccionada = 0;
        }
    }




    public void RecuadroLaboratorioPiedra()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoAlquimistasSeleccionarPiedra <= 0)
        {
            recuadroAlquimistasSeleccionarPiedra.SetActive(true);
            puntoAlquimistasSeleccionarPiedra = 1;
        }
        else
        {
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            puntoAlquimistasSeleccionarPiedra = 0;
        }
    }
    public void Laboratorio()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoLaboratorio <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(true);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 1;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
            puntoDeposito = 0;
            puntoMiners = 0;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraDesbloqRGBPotion >= 0)
            {
                botonMenuLaboratorio1.SetActive(true);
                botonMenuLaboratorio2.SetActive(true);
            }
        }
        else
        {
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
        }
    }
    public void BotonLaboratorio1()
    {
        recuadroLaboratorio.SetActive(true);
        recuadroLaboratorio2.SetActive(false);
    }
    public void BotonLaboratorio2()
    {
        recuadroLaboratorio.SetActive(false);
        recuadroLaboratorio2.SetActive(true);
    }
    public void Succion()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoSuccion <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroSuccion.SetActive(true);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);;
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 1;
            puntoTruck = 0;
            puntoCasa1 = 0;
            puntoDeposito = 0;
            puntoMiners = 0;
        }
        else
        {
            recuadroSuccion.SetActive(false);
            puntoSuccion = 0;
        }
    }
    public void Deposito()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Intro>().puntoTruckEnDepositoIntro >= 1)
        {
            if (puntoDeposito <= 0)
            {
                recuadroObelisco1.SetActive(false);
                recuadroCasa1.SetActive(false);
                recuadroDeposito.SetActive(true);
                recuadroTruck.SetActive(false);
                recuadroDepositoTutorialQuitar.SetActive(false);
                recuadroObelisco1.SetActive(false);
                recuadroSuccion.SetActive(false);
                recuadroMiners.SetActive(false);
                recuadroObelisco2.SetActive(false);
                recuadroCasa2.SetActive(false);
                recuadroObelisco3.SetActive(false);
                recuadroCasa3.SetActive(false);
                recuadroIglesia.SetActive(false);
                recuadroLaboratorio.SetActive(false);
                recuadroAlquimistasSeleccionarPiedra.SetActive(false);
                recuadroObservatorio.SetActive(false);
                recuadroPark.SetActive(false);
                recuadroSilo.SetActive(false);
                recuadroDrillGlobal.SetActive(false);
                botonMenuLaboratorio1.SetActive(false);
                botonMenuLaboratorio2.SetActive(false);
                recuadroLaboratorio2.SetActive(false);
                puntoRecuadroMostrarCambiarRoca = 0;
                puntoSilo = 0;
                puntoPark = 0;
                puntoDrill = 0;
                puntoObservatorio = 0;
                puntoLaboratorio = 0;
                puntoAlquimistasSeleccionarPiedra = 0;
                puntoIglesia = 0;
                puntoCasa2 = 0;
                puntoCasa3 = 0;
                puntoSuccion = 0;
                puntoDeposito = 1;
                puntoTruck = 0;
                puntoCasa1 = 0;
                puntoMiners = 0;
            }
            else
            {
                recuadroDeposito.SetActive(false);
                puntoDeposito = 0;
            }
        }
        
    }
    public void Miners()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoMiners <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroMiners.SetActive(true);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
            puntoMiners = 1;
        }
        else
        {
            recuadroMiners.SetActive(false);
            puntoMiners = 0;
        }
    }
    public void Truck()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoTruck <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(true);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoCasa1 = 0;
            puntoTruck = 1;
        }
        else
        {
            recuadroTruck.SetActive(false);
            puntoTruck = 0;
        }
    }
    public void Casa1()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa1 <= 0)
        {
            recuadroCasa1.SetActive(true);
            if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 1)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 2;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 2)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 2.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 3)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 3.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 4)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 4.25f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 5)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 5;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 6)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 5.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 7)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 6.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa1 == 8)
            {
                recuadroCasa1.transform.position = posicionCasa1.transform.position + Vector3.up * 7.25f;
            }
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroDrillGlobal.SetActive(false); 
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 1;
        }
        else
        {
            recuadroCasa1.SetActive(false);
            puntoCasa1 = 0;
        }
    }
    public void Altar1()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa1 <= 0)
        {
            recuadroObelisco1.SetActive(true);
            recuadroCasa1.SetActive(false);         
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 1;
        }
        else
        {
            recuadroObelisco1.SetActive(false);
            puntoCasa1 = 0;
        }
    }
    public void Casa2()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa2 <= 0)
        {
            recuadroCasa2.SetActive(true);
            if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 1)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 2;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 2)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 2.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 3)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 3.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 4)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 4.25f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 5)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 5;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 6)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 5.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 7)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 6.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa2 == 8)
            {
                recuadroCasa2.transform.position = posicionCasa2.transform.position + Vector3.up * 7.25f;
            }
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            mostrarCambiarRoca.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 1;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroCasa2.SetActive(false);
            puntoCasa2 = 0;
        }
    }
    public void Altar2()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa2 <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(true);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 1;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroObelisco2.SetActive(false);
            puntoCasa2 = 0;
        }
    }
    public void Casa3()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa3 <= 0)
        {
            recuadroCasa3.SetActive(true);
            if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 1)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 2;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 2)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 2.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 3)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 3.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 4)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 4.25f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 5)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 5;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 6)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 5.75f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 7)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 6.5f;
            }
            else if (GetComponent<MejorasCasa>().nivelMejoraMasCapacidadCasa3 == 8)
            {
                recuadroCasa3.transform.position = posicionCasa3.transform.position + Vector3.up * 7.25f;
            }
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroObelisco1.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 1;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroCasa3.SetActive(false);
            puntoCasa3 = 0;
        }
    }
    public void Altar3()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoCasa3 <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(true);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 1;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroObelisco3.SetActive(false);
            puntoCasa3 = 0;
        }
    }
    public void Iglesia()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoIglesia <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(true);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 1;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroIglesia.SetActive(false);
            puntoIglesia = 0;
        }
    }

    public void Observatorio()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoObservatorio <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(true);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 1;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
        }
    }
    public void Drill()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoDrill <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroDrillGlobal.SetActive(true);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoSilo = 0;
            puntoPark = 0;
            puntoDrill = 1;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraDesbloqZafiro >= 1)
            {
                botonMenuDrill1.SetActive(true);
                botonMenuDrill2.SetActive(true);
                botonCambiarRoca.SetActive(true);
            }
        }
        else
        {
            recuadroDrillGlobal.SetActive(false);
            puntoDrill = 0;
        }
    }
    public void RecuadroCambiarRoca()
    {
        if (puntoRecuadroMostrarCambiarRoca <= 0)
        {
            puntoRecuadroMostrarCambiarRoca = 1;
            mostrarCambiarRoca.SetActive(true);
        }
        else
        {
            mostrarCambiarRoca.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
        }
       
    }
    //al cambiar a que tipo de piedra minan los drills, se llama a estas funciones para destruirlos, instanciar nuevos, y tiene un cd de 2s asi le da tiempo al juego a destruir todos los drills y que no interfiera si se llaman varias veces las funciones en poco tiempo
    public void CambiarAOro()
    {
        if (puntoPiedraGoldSeleccionada <= 0 && puntoVolverAActivarBoton <= 0 && GetComponent<Recursos>().cantidadDrillsEnPantalla == GetComponent<Recursos>().cantidadDrills || puntoPiedraGoldSeleccionada <= 0 && puntoVolverAActivarBoton <= 0 && GetComponent<Recursos>().cantidadDrills == 0)
        {
            botonCambiarRoca.GetComponent<Image>().sprite = gold;
            puntoPiedraGoldSeleccionada = 1;
            puntoPiedraZafiroSeleccionada = 0;
            puntoVolverAActivarBoton = 1;
            GetComponent<Recursos>().cantidadDrillsEnPantalla = 0;
            GetComponent<Recursos>().puntoDestruirDrill = 1;
            Invoke(nameof(QuitarPuntoDestruirDrills2), 2f);
            Invoke(nameof(ActivarBoton), 5f);
        }
       
    }
    public void CambiarAZafiro()
    {
        if (puntoPiedraZafiroSeleccionada <= 0 && puntoVolverAActivarBoton <= 0 && GetComponent<Recursos>().cantidadDrillsEnPantalla == GetComponent<Recursos>().cantidadDrills || puntoPiedraZafiroSeleccionada <= 0 && puntoVolverAActivarBoton <= 0 && GetComponent<Recursos>().cantidadDrills == 0)
        {
            botonCambiarRoca.GetComponent<Image>().sprite = zafiro;
            puntoPiedraGoldSeleccionada = 0;
            puntoPiedraZafiroSeleccionada = 1;
            puntoVolverAActivarBoton = 1;
            GetComponent<Recursos>().cantidadDrillsEnPantalla = 0;
            GetComponent<Recursos>().puntoDestruirDrill = 1;
            Invoke(nameof(QuitarPuntoDestruirDrills), 2f);
            Invoke(nameof(ActivarBoton), 5f);
        }
       
    }
   
    void QuitarPuntoDestruirDrills()
    {
        GetComponent<Recursos>().puntoDestruirDrill = 0;
        GetComponent<Recursos>().SpawnDrillsZafiro();
    }
    void QuitarPuntoDestruirDrills2()
    {
        GetComponent<Recursos>().puntoDestruirDrill = 0;
        GetComponent<Recursos>().SpawnDrills();
    }
    void ActivarBoton()
    {
        puntoVolverAActivarBoton = 0;
    }
    public void BotonDrill1()
    {
        recuadroDrill.SetActive(true);
        recuadroDrill2.SetActive(false);
    }
    public void BotonDrill2()
    {
        recuadroDrill.SetActive(false);
        recuadroDrill2.SetActive(true);
    }
    public void Park()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoPark <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(true);
            recuadroSilo.SetActive(false);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 0;
            puntoPark = 1;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroPark.SetActive(false);
            puntoPark = 0;
        }
    }
    public void Silo()
    {
        AudioManager.instance.PlaySFX("Click");
        if (puntoSilo <= 0)
        {
            recuadroObelisco1.SetActive(false);
            recuadroCasa1.SetActive(false);
            recuadroDeposito.SetActive(false);
            recuadroTruck.SetActive(false);
            recuadroDepositoTutorialQuitar.SetActive(false);
            recuadroMiners.SetActive(false);
            recuadroSuccion.SetActive(false);
            recuadroObelisco2.SetActive(false);
            recuadroCasa2.SetActive(false);
            recuadroObelisco3.SetActive(false);
            recuadroCasa3.SetActive(false);
            recuadroIglesia.SetActive(true);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            recuadroPark.SetActive(false);
            recuadroSilo.SetActive(true);
            recuadroDrillGlobal.SetActive(false);
            botonMenuLaboratorio1.SetActive(false);
            botonMenuLaboratorio2.SetActive(false);
            recuadroLaboratorio2.SetActive(false);
            puntoRecuadroMostrarCambiarRoca = 0;
            puntoSilo = 1;
            puntoPark = 0;
            puntoDrill = 0;
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoMiners = 0;
            puntoDeposito = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
        }
        else
        {
            recuadroSilo.SetActive(false);
            puntoSilo = 0;
        }
    }


}
