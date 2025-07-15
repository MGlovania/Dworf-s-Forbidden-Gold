using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasTruck : MonoBehaviour
{
    public GameObject truck;

    public TMP_Text costeOroMejoraMasCapacidadText;
    public TMP_Text costeOroMejoraMasVelocidadText;

    public TMP_Text nivelOroMejoraMasCapacidadText;
    public TMP_Text nivelOroMejoraMasVelocidadText;

    public double costeOroMejoraMasCapacidad;
    public int nivelMejoraMasCapacidad;

    public double costeOroMejoraMasVelocidad;
    public int nivelMejoraMasVelocidad;



    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraMasCapacidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidad", "5"));
        nivelMejoraMasCapacidad = PlayerPrefs.GetInt("NivelMejoraMasCapacidad");
        costeOroMejoraMasVelocidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasVelocidad", "10"));
        nivelMejoraMasVelocidad = PlayerPrefs.GetInt("NivelMejoraMasVelocidad");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        nivelOroMejoraMasCapacidadText.text = "(" + nivelMejoraMasCapacidad.ToString("F0") + ")";
        if (nivelMejoraMasVelocidad >= 15)
        {
            nivelOroMejoraMasVelocidadText.text = "(Max)";
        }
        else
        {
            nivelOroMejoraMasVelocidadText.text = "(" + nivelMejoraMasVelocidad.ToString("F0") + ")";
        }

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
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidad)
        {
            ObjectPool.SpawnObject(particulasMejora, truck.transform.position, Quaternion.identity);
            AudioManager.instance.PlaySFX("Mejora");
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidad;
            GetComponent<Recursos>().cargoMaxCamion *= 1.5f;
            costeOroMejoraMasCapacidad *= 2f;
            nivelMejoraMasCapacidad += 1;
        }
    }
    public void MejoraMasVelocidad()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad && nivelMejoraMasVelocidad < 15)
        {
            ObjectPool.SpawnObject(particulasMejora, truck.transform.position, Quaternion.identity);
            AudioManager.instance.PlaySFX("Mejora");
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            truck.GetComponent<CamionDeCargo>().speed *= 1.2f;
            if (nivelMejoraMasVelocidad >= 10)
            {
                costeOroMejoraMasVelocidad *= 5f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 2.25f;
            }
        
            nivelMejoraMasVelocidad += 1;
        }
    }
    public void MejoraProbBounce()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad && nivelMejoraMasVelocidad < 6)
        {
            ObjectPool.SpawnObject(particulasMejora, truck.transform.position, Quaternion.identity);
            AudioManager.instance.PlaySFX("Mejora");
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            if (nivelMejoraMasVelocidad >= 4)
            {
                costeOroMejoraMasVelocidad *= 3.5f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 2.2f;
            }

            nivelMejoraMasVelocidad += 1;
        }
    }
    public void MejoraMasValor()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad)
        {
            ObjectPool.SpawnObject(particulasMejora, truck.transform.position, Quaternion.identity);
            AudioManager.instance.PlaySFX("Mejora");
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            GetComponent<Recursos>().valorPiedra *= 1.5f;
            if (nivelMejoraMasVelocidad >= 7)
            {
                costeOroMejoraMasVelocidad *= 3.5f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 2.25f;
            }

            nivelMejoraMasVelocidad += 1;
        }
    }


}
