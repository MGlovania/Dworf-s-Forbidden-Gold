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
    public int puntoLaboratorio;

    public GameObject recuadroAlquimistasSeleccionarConstruccion;
    public int puntoAlquimistasSeleccionarConstruccion;

    public GameObject recuadroAlquimistasSeleccionarPiedra;
    public int puntoAlquimistasSeleccionarPiedra;

    public Image recuadroTruckLaboratorio;
    public Image recuadroCasaLaboratorio;
    public Image recuadroDepositoLaboratorio;
    public Image recuadroMinerosLaboratorio;
    public Image recuadroIglesiaLaboratorio;
    public Image recuadroCannonLaboratorio;
    public Image recuadroLaboratorioLaboratorio;
    public Image recuadroDrillLaboratorio;
    public Image recuadroObservatorioLaboratorio;
    public Image recuadroDronesLaboratorio;
    public Image recuadroCementerioLaboratorio;
    public Image recuadroRocketSiloLaboratorio;
    public Image recuadroExtremeLaboratorio;
    public Sprite recuadroTruckLaboratorioDesSeleccionado;
    public Sprite recuadroCasaLaboratorioDesSeleccionado;
    public Sprite recuadroDepositoLaboratorioDesSeleccionado;
    public Sprite recuadroMinerosLaboratorioDesSeleccionado;
    public Sprite recuadroIglesiaLaboratorioDesSeleccionado;
    public Sprite recuadroCannonLaboratorioDesSeleccionado;
    public Sprite recuadroLaboratorioLaboratorioDesSeleccionado;
    public Sprite recuadroDrillLaboratorioDesSeleccionado;
    public Sprite recuadroObservatorioLaboratorioDesSeleccionado;
    public Sprite recuadroDronesLaboratorioDesSeleccionado;
    public Sprite recuadroCementerioLaboratorioDesSeleccionado;
    public Sprite recuadroRocketSiloLaboratorioDesSeleccionado;
    public Sprite recuadroExtremeLaboratorioDesSeleccionado;
    public Sprite recuadroTruckLaboratorioSeleccionado;
    public Sprite recuadroCasaLaboratorioSeleccionado;
    public Sprite recuadroDepositoLaboratorioSeleccionado;
    public Sprite recuadroMinerosLaboratorioSeleccionado;
    public Sprite recuadroIglesiaLaboratorioSeleccionado;
    public Sprite recuadroCannonLaboratorioSeleccionado;
    public Sprite recuadroLaboratorioLaboratorioSeleccionado;
    public Sprite recuadroDrillLaboratorioSeleccionado;
    public Sprite recuadroObservatorioLaboratorioSeleccionado;
    public Sprite recuadroDronesLaboratorioSeleccionado;
    public Sprite recuadroCementerioLaboratorioSeleccionado;
    public Sprite recuadroRocketSiloLaboratorioSeleccionado;
    public Sprite recuadroExtremeLaboratorioSeleccionado;
    public int puntoTruckLaboratorioSeleccionado;
    public int puntoCasaLaboratorioSeleccionado;
    public int puntoDepositoLaboratorioSeleccionado;
    public int puntoMinerosLaboratorioSeleccionado;
    public int puntoIglesiaLaboratorioSeleccionado;
    public int puntoCannonLaboratorioSeleccionado;
    public int puntoLaboratorioLaboratorioSeleccionado;
    public int puntoDrillLaboratorioSeleccionado;
    public int puntoObservatorioLaboratorioSeleccionado;
    public int puntoDronesLaboratorioSeleccionado;
    public int puntoCementerioLaboratorioSeleccionado;
    public int puntoRocketSiloLaboratorioSeleccionado;
    public int puntoExtremeLaboratorioSeleccionado;

    public Image pocionHardness;
    public Image pocionRGB;
    public Sprite pocionHardnessDesSeleccionada;
    public Sprite pocionRGBDesSeleccionada;
    public Sprite pocionHardnessSeleccionada;
    public Sprite pocionRGBSeleccionada;
    public int puntoHardnessSeleccionada;
    public int puntoRGBSeleccionada;

    public GameObject recuadroObservatorio;
    public int puntoObservatorio;

    void Start()
    {
        puntoTruckLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoTruckLaboratorioSeleccionado");
        puntoCasaLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoCasaLaboratorioSeleccionado");
        puntoDepositoLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoDepositoLaboratorioSeleccionado");
        puntoMinerosLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoMinerosLaboratorioSeleccionado");
        puntoIglesiaLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoIglesiaLaboratorioSeleccionado");
        puntoCannonLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoCannonLaboratorioSeleccionado");
        puntoLaboratorioLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoLaboratorioLaboratorioSeleccionado");
        puntoDrillLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoDrillLaboratorioSeleccionado");
        puntoObservatorioLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoObservatorioLaboratorioSeleccionado");
        puntoDronesLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoDronesLaboratorioSeleccionado");
        puntoCementerioLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoCementerioLaboratorioSeleccionado");
        puntoRocketSiloLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoRocketSiloLaboratorioSeleccionado");
        puntoExtremeLaboratorioSeleccionado = PlayerPrefs.GetInt("PuntoExtremeLaboratorioSeleccionado");
        puntoObservatorio = PlayerPrefs.GetInt("PuntoObservatorio");

        puntoHardnessSeleccionada = PlayerPrefs.GetInt("PuntoHardnessSeleccionada");
        puntoRGBSeleccionada = PlayerPrefs.GetInt("PuntoRGBSeleccionada");

        if (puntoTruckLaboratorioSeleccionado >= 1)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioSeleccionado;
        }
       else if (puntoDepositoLaboratorioSeleccionado >= 1)
        {
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioSeleccionado;
        }
        else if (puntoCasaLaboratorioSeleccionado >= 1)
        {
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioSeleccionado;
        }
        else if (puntoMinerosLaboratorioSeleccionado >= 1)
        {
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioSeleccionado;
        }
        else if (puntoIglesiaLaboratorioSeleccionado >= 1)
        {
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioSeleccionado;
        }
        else if (puntoCannonLaboratorioSeleccionado >= 1)
        {
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioSeleccionado;
        }
        else if (puntoLaboratorioLaboratorioSeleccionado >= 1)
        {
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioSeleccionado;
        }
        else if (puntoDrillLaboratorioSeleccionado >= 1)
        {
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
        }
        else if (puntoObservatorioLaboratorioSeleccionado >= 1)
        {
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioSeleccionado;
        }
        else if (puntoDronesLaboratorioSeleccionado >= 1)
        {
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioSeleccionado;
        }
        else if (puntoCementerioLaboratorioSeleccionado >= 1)
        {
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioSeleccionado;
        }
        else if (puntoRocketSiloLaboratorioSeleccionado >= 1)
        {
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioSeleccionado;
        }
        else if (puntoExtremeLaboratorioSeleccionado >= 1)
        {
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioSeleccionado;
        }
        if (puntoHardnessSeleccionada >= 1)
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
        PlayerPrefs.SetInt("PuntoTruckLaboratorioSeleccionado", puntoTruckLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoCasaLaboratorioSeleccionado", puntoCasaLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoDepositoLaboratorioSeleccionado", puntoDepositoLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoMinerosLaboratorioSeleccionado", puntoMinerosLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PpuntoIglesiaLaboratorioSeleccionado", puntoIglesiaLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoCannonLaboratorioSeleccionado", puntoCannonLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PpuntoLaboratorioLaboratorioSeleccionado", puntoLaboratorioLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoDrillLaboratorioSeleccionado", puntoDrillLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoObservatorioLaboratorioSeleccionado", puntoObservatorioLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoDronesLaboratorioSeleccionado", puntoDronesLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoCementerioLaboratorioSeleccionado", puntoCementerioLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoRocketSiloLaboratorioSeleccionado", puntoRocketSiloLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoExtremeLaboratorioSeleccionado", puntoExtremeLaboratorioSeleccionado);
        PlayerPrefs.SetInt("PuntoObservatorio", puntoObservatorio);

        PlayerPrefs.SetInt("PuntoHardnessSeleccionada", puntoHardnessSeleccionada);
        PlayerPrefs.SetInt("PuntoRGBSeleccionada", puntoRGBSeleccionada);

     
    }
    public void PocionHardness()
    {
        if (puntoHardnessSeleccionada <= 0)
        {
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
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
        if (puntoRGBSeleccionada <= 0)
        {
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBSeleccionada;
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 1;
        }
        else
        {
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoRGBSeleccionada = 0;
        }
    }
    public void SelectTruck()
    {
        if (puntoTruckLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 1;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            puntoTruckLaboratorioSeleccionado = 0;
        }
    }
    public void SelectCasa()
    {
        if (puntoCasaLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 1;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            puntoCasaLaboratorioSeleccionado = 0;
        }
    }
    public void SelectDeposito()
    {
        if (puntoDepositoLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 1;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            puntoDepositoLaboratorioSeleccionado = 0;
        }
    }
    public void SelectMineros()
    {
        if (puntoMinerosLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 1;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            puntoMinerosLaboratorioSeleccionado = 0;
        }
    }
    public void SelectIglesia()
    {
        if (puntoIglesiaLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 1;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            puntoIglesiaLaboratorioSeleccionado = 0;
        }
    }
    public void SelectCannon()
    {
        if (puntoCannonLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 1;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            puntoCannonLaboratorioSeleccionado = 0;
        }
    }
    public void SelectLaboratorio()
    {
        if (puntoLaboratorioLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 1;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            puntoLaboratorioLaboratorioSeleccionado = 0;
        }
    }
    public void SelectDrill()
    {
        if (puntoDrillLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 1;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            puntoDrillLaboratorioSeleccionado = 0;
        }
    }
    public void SelectObservatorio()
    {
        if (puntoObservatorioLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 1;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            puntoObservatorioLaboratorioSeleccionado = 0;
        }
    }
    public void SelectDrones()
    {
        if (puntoDronesLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 1;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            puntoDronesLaboratorioSeleccionado = 0;
        }
    }
    public void SelectCementerio()
    {
        if (puntoCementerioLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 1;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            puntoCementerioLaboratorioSeleccionado = 0;
        }
    }
    public void SelectRocketSilo()
    {
        if (puntoRocketSiloLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 1;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
        else
        {
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            puntoRocketSiloLaboratorioSeleccionado = 0;
        }
    }
    public void SelectExtreme()
    {
        if (puntoExtremeLaboratorioSeleccionado <= 0)
        {
            recuadroTruckLaboratorio.GetComponent<Image>().sprite = recuadroTruckLaboratorioDesSeleccionado;
            recuadroCasaLaboratorio.GetComponent<Image>().sprite = recuadroCasaLaboratorioDesSeleccionado;
            recuadroMinerosLaboratorio.GetComponent<Image>().sprite = recuadroMinerosLaboratorioDesSeleccionado;
            recuadroIglesiaLaboratorio.GetComponent<Image>().sprite = recuadroIglesiaLaboratorioDesSeleccionado;
            recuadroCannonLaboratorio.GetComponent<Image>().sprite = recuadroCannonLaboratorioDesSeleccionado;
            recuadroLaboratorioLaboratorio.GetComponent<Image>().sprite = recuadroLaboratorioLaboratorioDesSeleccionado;
            recuadroDrillLaboratorio.GetComponent<Image>().sprite = recuadroDrillLaboratorioDesSeleccionado;
            recuadroObservatorioLaboratorio.GetComponent<Image>().sprite = recuadroObservatorioLaboratorioDesSeleccionado;
            recuadroDronesLaboratorio.GetComponent<Image>().sprite = recuadroDronesLaboratorioDesSeleccionado;
            recuadroCementerioLaboratorio.GetComponent<Image>().sprite = recuadroCementerioLaboratorioDesSeleccionado;
            recuadroRocketSiloLaboratorio.GetComponent<Image>().sprite = recuadroRocketSiloLaboratorioDesSeleccionado;
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioSeleccionado;
            recuadroDepositoLaboratorio.GetComponent<Image>().sprite = recuadroDepositoLaboratorioDesSeleccionado;
            pocionHardness.GetComponent<Image>().sprite = pocionHardnessDesSeleccionada;
            pocionRGB.GetComponent<Image>().sprite = pocionRGBDesSeleccionada;
            puntoHardnessSeleccionada = 0;
            puntoRGBSeleccionada = 0;
            puntoDepositoLaboratorioSeleccionado = 0;
            puntoTruckLaboratorioSeleccionado = 0;
            puntoCasaLaboratorioSeleccionado = 0;
            puntoMinerosLaboratorioSeleccionado = 0;
            puntoIglesiaLaboratorioSeleccionado = 0;
            puntoCannonLaboratorioSeleccionado = 0;
            puntoLaboratorioLaboratorioSeleccionado = 0;
            puntoDrillLaboratorioSeleccionado = 0;
            puntoObservatorioLaboratorioSeleccionado = 0;
            puntoDronesLaboratorioSeleccionado = 0;
            puntoCementerioLaboratorioSeleccionado = 0;
            puntoRocketSiloLaboratorioSeleccionado = 0;
            puntoExtremeLaboratorioSeleccionado = 1;
        }
        else
        {
            recuadroExtremeLaboratorio.GetComponent<Image>().sprite = recuadroExtremeLaboratorioDesSeleccionado;
            puntoExtremeLaboratorioSeleccionado = 0;
        }
    }


    public void RecuadroLaboratorioConstruccion()
    {
        if (puntoAlquimistasSeleccionarConstruccion <= 0)
        {         
            recuadroAlquimistasSeleccionarConstruccion.SetActive(true);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            puntoAlquimistasSeleccionarConstruccion = 1;
            puntoAlquimistasSeleccionarPiedra = 0;
        }
        else
        {
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            puntoAlquimistasSeleccionarConstruccion = 0;
        }
    }
    public void RecuadroLaboratorioPiedra()
    {
        if (puntoAlquimistasSeleccionarPiedra <= 0)
        {
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(true);
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 1;
            puntoAlquimistasSeleccionarConstruccion = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
            puntoIglesia = 0;
            puntoCasa2 = 0;
            puntoCasa3 = 0;
            puntoSuccion = 0;
            puntoTruck = 0;
            puntoCasa1 = 0;
            puntoDeposito = 0;
            puntoMiners = 0;
        }
        else
        {
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroLaboratorio.SetActive(false);
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
            puntoAlquimistasSeleccionarPiedra = 0;
        }
    }
    public void Succion()
    {
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
                recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
                recuadroAlquimistasSeleccionarPiedra.SetActive(false);
                recuadroObservatorio.SetActive(false);
                puntoObservatorio = 0;
                puntoLaboratorio = 0;
                puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
        if (puntoIglesia <= 0)
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
            recuadroIglesia.SetActive(true);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(false);
            puntoObservatorio = 0;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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
            recuadroIglesia.SetActive(true);
            recuadroLaboratorio.SetActive(false);
            recuadroAlquimistasSeleccionarConstruccion.SetActive(false);
            recuadroAlquimistasSeleccionarPiedra.SetActive(false);
            recuadroObservatorio.SetActive(true);
            puntoObservatorio = 1;
            puntoLaboratorio = 0;
            puntoAlquimistasSeleccionarConstruccion = 0;
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


}
