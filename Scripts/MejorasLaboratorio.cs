using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasLaboratorio : MonoBehaviour
{
    public TMP_Text costeOroMejoraHardnessText;
    public TMP_Text costeOroMejoraMasAlquimistasText;
    public TMP_Text costeZafiroMejoraPocionEfficiencyText;
    public TMP_Text costeZafiroMejoraPocionHardnessText;

    public double costeOroMejoraHardness;
    public int nivelMejoraMasHardness;

    public double costeOroMejoraMasAlquimistas;
    public int nivelMejoraMasAlquimistas;

    public double costeZafiroMejoraPocionEfficiency;
    public int nivelMejoraPocionEfficiency;

    public double costeZafiroMejoraPocionHardness;
    public int nivelMejoraPocionHardness;



    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraHardness = double.Parse(PlayerPrefs.GetString("CosteOroMejoraHardness", "100"));
        nivelMejoraMasHardness = PlayerPrefs.GetInt("NivelMejoraMasHardness");
        costeOroMejoraMasAlquimistas = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasAlquimistas", "150"));
        nivelMejoraMasAlquimistas = PlayerPrefs.GetInt("NivelMejoraMasAlquimistas");
        costeZafiroMejoraPocionEfficiency = double.Parse(PlayerPrefs.GetString("CosteZafiroMejoraPocionEfficiency", "50"));
        nivelMejoraPocionEfficiency = PlayerPrefs.GetInt("NivelMejoraPocionEfficiency");
        costeZafiroMejoraPocionHardness = double.Parse(PlayerPrefs.GetString("CosteZafiroMejoraPocionHardness", "100"));
        nivelMejoraPocionHardness = PlayerPrefs.GetInt("NivelMejoraPocionHardness");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraHardness", costeOroMejoraHardness.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasHardness", nivelMejoraMasHardness);
        PlayerPrefs.SetString("CosteOroMejoraMasAlquimistas", costeOroMejoraMasAlquimistas.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasAlquimistas", nivelMejoraMasAlquimistas);
        PlayerPrefs.SetString("CosteZafiroMejoraPocionEfficiency", costeZafiroMejoraPocionEfficiency.ToString());
        PlayerPrefs.SetInt("NivelMejoraPocionEfficiency", nivelMejoraPocionEfficiency);
        PlayerPrefs.SetString("CosteZafiroMejoraPocionHardness", costeZafiroMejoraPocionHardness.ToString());
        PlayerPrefs.SetInt("NivelMejoraPocionHardness", nivelMejoraPocionHardness);
    
        if (costeOroMejoraHardness >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraHardness))));
            var mantissa = (costeOroMejoraHardness / System.Math.Pow(10, exponent));
            costeOroMejoraHardnessText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraHardnessText.text = costeOroMejoraHardness.ToString("F0");

        }
        if (costeOroMejoraMasAlquimistas >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasAlquimistas))));
            var mantissa = (costeOroMejoraMasAlquimistas / System.Math.Pow(10, exponent));
            costeOroMejoraMasAlquimistasText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasAlquimistasText.text = costeOroMejoraMasAlquimistas.ToString("F0");

        }
        if (costeZafiroMejoraPocionEfficiency >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMejoraPocionEfficiency))));
            var mantissa = (costeZafiroMejoraPocionEfficiency / System.Math.Pow(10, exponent));
            costeZafiroMejoraPocionEfficiencyText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMejoraPocionEfficiencyText.text = costeZafiroMejoraPocionEfficiency.ToString("F0");

        }
        if (costeZafiroMejoraPocionHardness >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMejoraPocionHardness))));
            var mantissa = (costeZafiroMejoraPocionHardness / System.Math.Pow(10, exponent));
            costeZafiroMejoraPocionHardnessText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMejoraPocionHardnessText.text = costeZafiroMejoraPocionHardness.ToString("F0");

        }
     
       
    }
    public void MejoraMasHardness()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraHardness)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraHardness;
            GetComponent<Recursos>().vidaMaxPiedra *= 5;
            GetComponent<Recursos>().pesoPiedra *= 5;
            GetComponent<Recursos>().valorPiedra *= 5;
            if (nivelMejoraMasHardness > 5)
            {
                costeOroMejoraHardness *= 30f;
            }
            else
            {
                costeOroMejoraHardness *= 20;
            }
            nivelMejoraMasHardness += 1;
        }
    }
    public void MejoraMasAlquimistas()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasAlquimistas)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasAlquimistas;
            GetComponent<Recursos>().vidaMaxPiedra *= 5;
            GetComponent<Recursos>().pesoPiedra *= 5;
            GetComponent<Recursos>().valorPiedra *= 5;
         
                costeOroMejoraMasAlquimistas *= 20;

            nivelMejoraMasHardness += 1;
        }
    }
}
