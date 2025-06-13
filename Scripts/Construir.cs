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



    public GameObject particulasConstruir;
    void Start()
    {
        costeGoldCasa2 = double.Parse(PlayerPrefs.GetString("CosteGoldCasa2", "500"));
        costeGoldCasa3 = double.Parse(PlayerPrefs.GetString("CosteGoldCasa2", "4000"));
        costeGoldCasaMineros = double.Parse(PlayerPrefs.GetString("CosteGoldCasaMineros", "50"));
        costeGoldCatedral = double.Parse(PlayerPrefs.GetString("CosteGoldCatedral", "125"));
        costeGoldLaboratorio = double.Parse(PlayerPrefs.GetString("CosteGoldLaboratorio", "75"));
        costeGoldObservatorio = double.Parse(PlayerPrefs.GetString("CosteGoldObservatorio", "1000"));
        puntoCasaMinerosConstruida = PlayerPrefs.GetInt("PuntoCasaMinerosConstruida");
        puntoCasa2Cosntruida = PlayerPrefs.GetInt("PuntoCasa2Cosntruida");
        puntoCasa3Cosntruida = PlayerPrefs.GetInt("PuntoCasa3Cosntruida");
        puntoSuctionMachineCosntruida = PlayerPrefs.GetInt("PuntoSuctionMachineCosntruida");
        puntoCatedralCosntruida = PlayerPrefs.GetInt("PuntoCatedralCosntruida");
        puntoLaboratorioCosntruida = PlayerPrefs.GetInt("PuntoLaboratorioCosntruida");
        puntoObservatorioCosntruida = PlayerPrefs.GetInt("PuntoObservatorioCosntruida");
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
        Invoke(nameof(Verif), 0.25f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.25f);
        PlayerPrefs.SetString("CosteGoldCasa2", costeGoldCasa2.ToString());
        PlayerPrefs.SetString("CosteGoldCasa3", costeGoldCasa3.ToString());
        PlayerPrefs.SetString("CosteGoldCasaMineros", costeGoldCasaMineros.ToString());
        PlayerPrefs.SetString("CosteGoldCatedral", costeGoldCatedral.ToString());
        PlayerPrefs.SetString("CosteGoldLaboratorio", costeGoldLaboratorio.ToString());
        PlayerPrefs.SetString("CosteGoldObservatorio", costeGoldObservatorio.ToString());
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
    }
    public void ConstruirCasa2()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasa2)
        {
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-13.18f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCasa2;
            iconoConstruirCasa2.SetActive(false);
            hoverCasa2.SetActive(false);
            casa2.SetActive(true);
            puntoCasa2Cosntruida = 1;
            PlayerPrefs.SetInt("PuntoCasa2Cosntruida", puntoCasa2Cosntruida);
        }
    }
    public void ConstruirCasa3()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasa3)
        {
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-14.62f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldCasa3;
            iconoConstruirCasa3.SetActive(false);
            hoverCasa3.SetActive(false);
            casa3.SetActive(true);
            puntoCasa3Cosntruida = 1;
            PlayerPrefs.SetInt("PuntoCasa3Cosntruida", puntoCasa3Cosntruida);
        }
    }
    public void ConstruirCasaMineros()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCasaMineros)
        {
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
        if (GetComponent<Intro>().puntoComprarSuction >= 1)
        {
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
        if (GetComponent<Recursos>().cantidadOro >= costeGoldCatedral)
        {
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
        if (GetComponent<Recursos>().cantidadOro >= costeGoldLaboratorio)
        {
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
        if (GetComponent<Recursos>().cantidadOro >= costeGoldObservatorio)
        {
            ObjectPool.SpawnObject(particulasConstruir, new Vector3(-37.47f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeGoldObservatorio;
            iconoConstruirObservatorio.SetActive(false);
            hoverObservatorio.SetActive(false);
            observatorio.SetActive(true);
            puntoObservatorioCosntruida = 1;
            PlayerPrefs.SetInt("PuntoObservatorioCosntruida", puntoObservatorioCosntruida);
        }
    }


}
