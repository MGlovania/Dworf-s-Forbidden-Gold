using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasDeposito : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasCollectorsText;
    public TMP_Text costeOroMejoraMasSpeedText;
    public TMP_Text costeOroMejoraMasCapacidadText;

    public double costeOroMejoraMasCollectors;
    public int nivelMejoraMasCollectors;

    public double costeOroMejoraMasVelocidad;
    public int nivelMejoraMasVelocidad;

    public double costeOroMejoraMasCapacidad;
    public int nivelMejoraMasCapacidad;

    public GameObject truck;



    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraMasCollectors = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCollectors", "0"));
        nivelMejoraMasCollectors = PlayerPrefs.GetInt("NivelMejoraMasCollectors");
        costeOroMejoraMasVelocidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasVelocidad", "5"));
        nivelMejoraMasVelocidad = PlayerPrefs.GetInt("NivelMejoraMasVelocidad");
        costeOroMejoraMasCapacidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidad", "10"));
        nivelMejoraMasCapacidad = PlayerPrefs.GetInt("NivelMejoraMasCapacidad");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasCollectors", costeOroMejoraMasCollectors.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCollectors", nivelMejoraMasCollectors);
        PlayerPrefs.SetString("CosteOroMejoraMasVelocidad", costeOroMejoraMasVelocidad.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasVelocidad", nivelMejoraMasVelocidad);
        PlayerPrefs.SetString("CosteOroMejoraMasCapacidad", costeOroMejoraMasCapacidad.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCapacidad", nivelMejoraMasCapacidad);
        if (costeOroMejoraMasCollectors >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasCollectors))));
            var mantissa = (costeOroMejoraMasCollectors / System.Math.Pow(10, exponent));
            costeOroMejoraMasCollectorsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasCollectorsText.text = costeOroMejoraMasCollectors.ToString("F0");

        }
        if (costeOroMejoraMasVelocidad >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasVelocidad))));
            var mantissa = (costeOroMejoraMasVelocidad / System.Math.Pow(10, exponent));
            costeOroMejoraMasSpeedText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasSpeedText.text = costeOroMejoraMasVelocidad.ToString("F0");

        }
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
    }

    public void MejoraMasCollectors()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCollectors && nivelMejoraMasCollectors < 20)
        {
           
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCollectors;
            GetComponent<Recursos>().cantidadDworfsSinEmpleo -= 1;
            GetComponent<Recursos>().cantidadDworfsCollectors += 1;
            if (costeOroMejoraMasCollectors == 0)
            {
                costeOroMejoraMasCollectors = 50;
            }
            else
            {
                costeOroMejoraMasCollectors *= 3;
            }
        
            nivelMejoraMasCollectors += 1;
            GameObject obj = GameObject.FindGameObjectWithTag("Aldeano");
            //GameObject obj = GameObject.FindFirstObjectByType<Aldeano>().gameObject;
            if (obj != null)
            {
                ObjectPool.ReturnObjectToPool(obj);
            }
        }
    }
    public void MejoraMasVelocidad()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad && nivelMejoraMasVelocidad < 20)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            GetComponent<Recursos>().speedCollectors *= 1.1f;
            GetComponent<Recursos>().speedCollectorsRecolectar /= 1.1f;
            if (nivelMejoraMasVelocidad >= 10)
            {
                costeOroMejoraMasVelocidad *= 5f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 2f;
            }
            nivelMejoraMasVelocidad += 1;
        }
    }
    public void MejoraMasCapacidad()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidad)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidad;
            GetComponent<Recursos>().cargoMaxCollectors *= 1.2f;

            costeOroMejoraMasCapacidad *= 2.25f;
            nivelMejoraMasCapacidad += 1;
        }
    }


   
}
