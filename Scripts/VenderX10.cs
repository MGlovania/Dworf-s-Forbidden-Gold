using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenderX10 : MonoBehaviour
{
    public GameObject botonBuyX1;
    public GameObject botonBuyX10;
    public int puntoBotonBuyX1;
    public int puntoBotonBuyX10;
    public Sprite botonVenderDeseleccionado;
    public Sprite botonVenderSeleccionado;

    void Start()
    {
        puntoBotonBuyX1 = PlayerPrefs.GetInt("PuntoBotonBuyX1");
        puntoBotonBuyX10 = PlayerPrefs.GetInt("PuntoBotonBuyX10");
        if (puntoBotonBuyX10 >= 1)
        {
            botonBuyX1.GetComponent<SpriteRenderer>().sprite = botonVenderDeseleccionado;
            botonBuyX10.GetComponent<SpriteRenderer>().sprite = botonVenderSeleccionado;
        }
    }

    public void VenderX1()
    {
        puntoBotonBuyX1 = 1;
        puntoBotonBuyX10 = 0;
            botonBuyX1.GetComponent<SpriteRenderer>().sprite = botonVenderSeleccionado;
            botonBuyX10.GetComponent<SpriteRenderer>().sprite = botonVenderDeseleccionado;
      
        
    }
    public void VenderX10XD()
    {
        puntoBotonBuyX1 = 0;
        puntoBotonBuyX10 = 1;
        botonBuyX1.GetComponent<SpriteRenderer>().sprite = botonVenderSeleccionado;
        botonBuyX10.GetComponent<SpriteRenderer>().sprite = botonVenderDeseleccionado;
        for (int i = 0; i < 10; i++)
        {
            GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa1 *= 2.5f;
            GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa2 *= 3f;
            GetComponent<MejorasCasa>().costeOroMejoraMasCapacidadCasa3 *= 3.5f;
            GetComponent<MejorasCasa>().costeOroMejoraObelisco1Daño *= 3;
            GetComponent<MejorasCasa>().costeOroMejoraObelisco2Daño *= 3.5f;
            GetComponent<MejorasCasa>().costeOroMejoraObelisco3Daño *= 4;
            GetComponent<MejorasCatedral>().costeOroMejoraMasDañoClick *= 1.75;
            GetComponent<MejorasCatedral>().costeOroMejoraMasProbCritClick *= 3;
            GetComponent<MejorasCatedral>().costeOroMejoraMasDañoCrit *= 2.25;
            GetComponent<MejorasCatedral>().costeOroMejoraMasFe *= 2.5;
            GetComponent<MejorasCatedral>().costeFeMejoraMasDañoClick *= 1.75f;
            GetComponent<MejorasCatedral>().costeFeMejoraMasDañoDworfs *= 2;
            GetComponent<MejorasCatedral>().costeFeMejoraMasValorOro *= 2.5f;
        }

    }
    void Update()
    {
        PlayerPrefs.SetInt("PuntoBotonBuyX1", puntoBotonBuyX1);
        PlayerPrefs.SetInt("PuntoBotonBuyX10", puntoBotonBuyX10);
    }
}
