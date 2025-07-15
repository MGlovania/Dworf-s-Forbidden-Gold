using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Construir : MonoBehaviour
{
    public TMP_Text costeGoldeCasa2Text;
    public TMP_Text costeGoldeCasa3Text;
    public TMP_Text costeGoldeCasaMinerosText;
    public TMP_Text costeGoldCatedralText;
    public TMP_Text costeGoldLaboratorioText;
    public TMP_Text costeGoldObservatorioText;
    public TMP_Text costeGoldDrillText;
    public TMP_Text costeGoldRocketText;
    public TMP_Text costeZafiroRocketText;

    public GameObject casa2;
    public GameObject hoverCasa2;
    public GameObject iconoConstruirCasa2;
    public int puntoCasa2Cosntruida;
    public double costeGoldCasa2;

    public GameObject casa3;
    public GameObject hoverCasa3;
    public GameObject iconoConstruirCasa3;
    public int puntoCasa3Cosntruida;
    public double costeGoldCasa3;

    public GameObject casaMineros;
    public GameObject iconoConstruirCasaMineros;
    public GameObject hoverMineros;
    public int puntoCasaMinerosConstruida;
    public double costeGoldCasaMineros;

    public GameObject suctionMachine;
    public GameObject iconoConstruirSuctionMachine;
    public GameObject hoverSuctionMachine;
    public int puntoSuctionMachineCosntruida;
    public GameObject quitarTutorial;

    public GameObject catedral;
    public GameObject iconoConstruirCatedral;
    public GameObject hoverCatedral;
    public int puntoCatedralCosntruida;
    public double costeGoldCatedral;

    public GameObject laboratorio;
    public GameObject iconoConstruirLaboratorio;
    public GameObject hoverLaboratorio;
    public int puntoLaboratorioCosntruida;
    public double costeGoldLaboratorio;

    public GameObject observatorio;
    public GameObject iconoConstruirObservatorio;
    public GameObject hoverObservatorio;
    public int puntoObservatorioCosntruida;
    public double costeGoldObservatorio;

    public GameObject drills;
    public GameObject iconoConstruirDrills;
    public GameObject hoverDrills;
    public int puntoDrillsCosntruida;
    public double costeGoldDrills;

    public GameObject rocket;
    public GameObject iconoConstruirRocket;
    public GameObject hoverRocket;
    public int puntoRocketCosntruida;
    public double costeGoldRocket;
    public double costeZafiroRocket;
    public GameObject demoEnds;


    public GameObject particulasConstruir;

    public GameObject prefabAldeano;

    public GameObject prestigio;
    void Start()
    {
        costeGoldCasa2 = double.Parse(PlayerPrefs.GetString("CosteGoldCasa2", "300"));
        costeGoldCasa3 = double.Parse(PlayerPrefs.GetString("CosteGoldCasa3", "2500"));
        costeGoldCasaMineros = double.Parse(PlayerPrefs.GetString("CosteGoldCasaMineros", "30"));
        costeGoldCatedral = double.Parse(PlayerPrefs.GetString("CosteGoldCatedral", "75"));
        costeGoldLaboratorio = double.Parse(PlayerPrefs.GetString("CosteGoldLaboratorio", "100"));
        costeGoldObservatorio = double.Parse(PlayerPrefs.GetString("CosteGoldObservatorio", "1000"));
        costeGoldDrills = double.Parse(PlayerPrefs.GetString("CosteGoldDrills", "2500"));
        costeGoldRocket = double.Parse(PlayerPrefs.GetString("CosteGoldRocket", "10000"));
        costeZafiroRocket = double.Parse(PlayerPrefs.GetString("CosteZafiroRocket", "250"));
        puntoCasaMinerosConstruida = PlayerPrefs.GetInt("PuntoCasaMinerosConstruida");
        puntoCasa2Cosntruida = PlayerPrefs.GetInt("PuntoCasa2Cosntruida");
        puntoCasa3Cosntruida = PlayerPrefs.GetInt("PuntoCasa3Cosntruida");
        puntoSuctionMachineCosntruida = PlayerPrefs.GetInt("PuntoSuctionMachineCosntruida");
        puntoCatedralCosntruida = PlayerPrefs.GetInt("PuntoCatedralCosntruida");
        puntoLaboratorioCosntruida = PlayerPrefs.GetInt("PuntoLaboratorioCosntruida");
        puntoObservatorioCosntruida = PlayerPrefs.GetInt("PuntoObservatorioCosntruida");
        puntoDrillsCosntruida = PlayerPrefs.GetInt("PuntoDrillsCosntruida");
        puntoRocketCosntruida = PlayerPrefs.GetInt("PuntoRocketCosntruida");
        if (puntoCasa2Cosntruida >= 1)
        {
            iconoConstruirCasa2.SetActive(false);
            casa2.SetActive(true);
        }
        if (puntoCasa3Cosntruida >= 1)
        {
            iconoConstruirCasa3.SetActive(false);
            casa3.SetActive(true);
        }
        if (puntoCasaMinerosConstruida >= 1)
        {
            iconoConstruirCasaMineros.SetActive(false);
            casaMineros.SetActive(true);
        }
        if (puntoSuctionMachineCosntruida >= 1)
        {
            iconoConstruirSuctionMachine.SetActive(false);
            suctionMachine.SetActive(true);
        }
        if (puntoCatedralCosntruida >= 1)
        {
            iconoConstruirCatedral.SetActive(false);
            catedral.SetActive(true);
        }
        if (puntoLaboratorioCosntruida >= 1)
        {
            iconoConstruirLaboratorio.SetActive(false);
            laboratorio.SetActive(true);
        }
        if (puntoObservatorioCosntruida >= 1)
        {
            iconoConstruirObservatorio.SetActive(false);
            observatorio.SetActive(true);
        }
        if (puntoDrillsCosntruida >= 1)
        {
            iconoConstruirDrills.SetActive(false);
            drills.SetActive(true);
        }
        if (puntoRocketCosntruida >= 1)
        {
            iconoConstruirRocket.SetActive(false);
            rocket.SetActive(true);
        }
        Invoke(nameof(Verif), 0.25f);
    }
//me quede seteando los rockets. ver cuantas mejoiras de zafiro tengo, añadir 1 mejora a park que sea de zafiro e incremente el valor gold
    void Verif()
    {
        Invoke(nameof(Verif), 0.25f);
        PlayerPrefs.SetString("CosteGoldCasa2", costeGoldCasa2.ToString());
        PlayerPrefs.SetString("CosteGoldCasa3", costeGoldCasa3.ToString());
        PlayerPrefs.SetString("CosteGoldCasaMineros", costeGoldCasaMineros.ToString());
        PlayerPrefs.SetString("CosteGoldCatedral", costeGoldCatedral.ToString());
        PlayerPrefs.SetString("CosteGoldLaboratorio", costeGoldLaboratorio.ToString());
        PlayerPrefs.SetString("CosteGoldObservatorio", costeGoldObservatorio.ToString());
        PlayerPrefs.SetString("CosteGoldDrills", costeGoldDrills.ToString());
        PlayerPrefs.SetString("CosteGoldRocket", costeGoldRocket.ToString());
        PlayerPrefs.SetString("CosteZafiroRocket", costeZafiroRocket.ToString());
        if (costeGoldCasa2 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldCasa2))));
            var mantissa = (costeGoldCasa2 / System.Math.Pow(10, exponent));
            costeGoldeCasa2Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldeCasa2Text.text = costeGoldCasa2.ToString("F0");

        }
        if (costeGoldCasa3 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldCasa3))));
            var mantissa = (costeGoldCasa3 / System.Math.Pow(10, exponent));
            costeGoldeCasa3Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldeCasa3Text.text = costeGoldCasa3.ToString("F0");

        }
        if (costeGoldCasaMineros >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldCasaMineros))));
            var mantissa = (costeGoldCasaMineros / System.Math.Pow(10, exponent));
            costeGoldeCasaMinerosText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldeCasaMinerosText.text = costeGoldCasaMineros.ToString("F0");

        }
        if (costeGoldCatedral >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldCatedral))));
            var mantissa = (costeGoldCatedral / System.Math.Pow(10, exponent));
            costeGoldCatedralText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldCatedralText.text = costeGoldCatedral.ToString("F0");

        }
        if (costeGoldLaboratorio >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldLaboratorio))));
            var mantissa = (costeGoldLaboratorio / System.Math.Pow(10, exponent));
            costeGoldCatedralText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldLaboratorioText.text = costeGoldLaboratorio.ToString("F0");

        }
        if (costeGoldObservatorio >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldObservatorio))));
            var mantissa = (costeGoldObservatorio / System.Math.Pow(10, exponent));
            costeGoldObservatorioText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldObservatorioText.text = costeGoldObservatorio.ToString("F0");

        }
        if (costeGoldDrills >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldDrills))));
            var mantissa = (costeGoldDrills / System.Math.Pow(10, exponent));
            costeGoldDrillText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldDrillText.text = costeGoldDrills.ToString("F0");

        }
        if (costeGoldRocket >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeGoldRocket))));
            var mantissa = (costeGoldRocket / System.Math.Pow(10, exponent));
            costeGoldRocketText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeGoldRocketText.text = costeGoldRocket.ToString("F0");

        }
        if (costeZafiroRocket >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroRocket))));
            var mantissa = (costeZafiroRocket / System.Math.Pow(10, exponent));
            costeZafiroRocketText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroRocketText.text = costeZafiroRocket.ToString("F0");

        }
    }
    public void ConstruirCasa2()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasa2)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-13.18f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCasa2;
            iconoConstruirCasa2.SetActive(false);
            hoverCasa2.SetActive(false);
            casa2.SetActive(true);
            puntoCasa2Cosntruida = 1;
            if (GetComponent<Recursos>().cantidadDworfsSinEmpleo <= 98)
            {
                ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
                ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
                GetComponent<Recursos>().cantidadDworfsSinEmpleo += 2;
                if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
                {
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                }
                
            }
            else
            {
                GetComponent<Recursos>().cantidadDworfsSinEmpleoAlmacenados += 2;
                if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
                {
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                }
            }
            PlayerPrefs.SetInt("PuntoCasa2Cosntruida", puntoCasa2Cosntruida);
        }
    }
    public void ConstruirCasa3()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasa3)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-14.62f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCasa3;
            iconoConstruirCasa3.SetActive(false);
            hoverCasa3.SetActive(false);
            casa3.SetActive(true);
            puntoCasa3Cosntruida = 1;
            if (GetComponent<Recursos>().cantidadDworfsSinEmpleo <= 98)
            {
                ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
                ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
                GetComponent<Recursos>().cantidadDworfsSinEmpleo += 2;
                if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
                {
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                }
            }
            else
            {
                GetComponent<Recursos>().cantidadDworfsSinEmpleoAlmacenados += 2;
                if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
                {
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                    GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
                }
            }
            PlayerPrefs.SetInt("PuntoCasa3Cosntruida", puntoCasa3Cosntruida);
        }
    }
    public void ConstruirCasaMineros()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasaMineros)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-9.68f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCasaMineros;
            iconoConstruirCasaMineros.SetActive(false);
            hoverMineros.SetActive(false);
            casaMineros.SetActive(true);
            puntoCasaMinerosConstruida = 1;
            PlayerPrefs.SetInt("PuntoCasaMinerosConstruida", puntoCasaMinerosConstruida);
        }
    }
    public void ConstruirSuctionMachine()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Intro>().puntoComprarSuction >= 1)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(3.76f, -3, 0), Quaternion.identity);
            iconoConstruirSuctionMachine.SetActive(false);
            hoverSuctionMachine.SetActive(false);
            suctionMachine.SetActive(true);
            puntoSuctionMachineCosntruida = 1;
            PlayerPrefs.SetInt("PuntoSuctionMachineCosntruida", puntoSuctionMachineCosntruida);
            quitarTutorial.SetActive(false);

        }
    

    }
    public void ConstruirCatedral()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCatedral)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCatedral;
            iconoConstruirCatedral.SetActive(false);
            hoverCatedral.SetActive(false);
            catedral.SetActive(true);
            puntoCatedralCosntruida = 1;
            PlayerPrefs.SetInt("PuntoCatedralCosntruida", puntoCatedralCosntruida);
        }
    }
    public void ConstruirLaboratorio()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldLaboratorio)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-16.73f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldLaboratorio;
            iconoConstruirLaboratorio.SetActive(false);
            hoverLaboratorio.SetActive(false);
            laboratorio.SetActive(true);
            puntoLaboratorioCosntruida = 1;
            PlayerPrefs.SetInt("PuntoLaboratorioCosntruida", puntoLaboratorioCosntruida);
        }
    }
    public void ConstruirObservatorio()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldObservatorio)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-28.46f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldObservatorio;
            iconoConstruirObservatorio.SetActive(false);
            hoverObservatorio.SetActive(false);
            observatorio.SetActive(true);
            puntoObservatorioCosntruida = 1;
            PlayerPrefs.SetInt("PuntoObservatorioCosntruida", puntoObservatorioCosntruida);
        }
    }
    public void ConstruirDrill()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldDrills)
        {
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-21.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldDrills;
            iconoConstruirDrills.SetActive(false);
            hoverDrills.SetActive(false);
            drills.SetActive(true);
            puntoDrillsCosntruida = 1;
            PlayerPrefs.SetInt("PuntoDrillsCosntruida", puntoDrillsCosntruida);
        }
    }
    public void ConstruirSilo()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeGoldRocket && GetComponent<Recursos>().cantidadZafiro >= costeZafiroRocket)
        {
            demoEnds.SetActive(true);
            AudioManager.instance.PlaySFX("Construir");
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-33.18f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldRocket;
            GetComponent<Recursos>().cantidadZafiro -= costeZafiroRocket;
            iconoConstruirRocket.SetActive(false);
            hoverRocket.SetActive(false);
            rocket.SetActive(true);
            puntoRocketCosntruida = 1;
            PlayerPrefs.SetInt("PuntoRocketCosntruida", puntoRocketCosntruida);
        }
    }
    public void CloseDemo()
    {
        demoEnds.SetActive(false);
    }

}
