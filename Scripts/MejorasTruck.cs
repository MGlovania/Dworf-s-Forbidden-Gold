using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasTruck : MonoBehaviour
{
    public GameObject truck;

    public TMP_Text costeOroMejoraMasCapacidadText;
    public TMP_Text costeOroMejoraMasVelocidadText;

    public double costeOroMejoraMasCapacidad;
    public int nivelMejoraMasCapacidad;

    public double costeOroMejoraMasVelocidad;
    public int nivelMejoraMasVelocidad;



    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraMasCapacidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidad", "5"));
        nivelMejoraMasCapacidad = PlayerPrefs.GetInt("NivelMejoraMasCapacidad");
        costeOroMejoraMasVelocidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasVelocidad", "5"));
        nivelMejoraMasVelocidad = PlayerPrefs.GetInt("NivelMejoraMasVelocidad");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasCapacidad", costeOroMejoraMasCapacidad.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCapacidad", nivelMejoraMasCapacidad);
        PlayerPrefs.SetString("CosteOroMejoraMasVelocidad", costeOroMejoraMasVelocidad.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasVelocidad", nivelMejoraMasVelocidad);
        if (costeOroMejoraMasCapacidad >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasCapacidad))));
            var mantissa = (costeOroMejoraMasCapacidad / System.Math.Pow(10, exponent));
            costeOroMejoraMasCapacidadText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasCapacidadText.text = costeOroMejoraMasCapacidad.ToString("F0");

        }
        if (costeOroMejoraMasVelocidad >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasVelocidad))));
            var mantissa = (costeOroMejoraMasVelocidad / System.Math.Pow(10, exponent));
            costeOroMejoraMasVelocidadText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasVelocidadText.text = costeOroMejoraMasVelocidad.ToString("F0");

        }
    }
    public void MejoraMasCapacidad()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidad)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidad;
            GetComponent<Recursos>().cargoMaxCamion *= 1.5f;
            costeOroMejoraMasCapacidad *= 2f;
            nivelMejoraMasCapacidad += 1;
        }
    }
    public void MejoraMasVelocidad()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad && nivelMejoraMasVelocidad < 20)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            truck.GetComponent<CamionDeCargo>().speed *= 1.1f;
            if (nivelMejoraMasVelocidad >= 10)
            {
                costeOroMejoraMasVelocidad *= 5f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 2.5f;
            }
        
            nivelMejoraMasVelocidad += 1;
        }
    }

   
}
