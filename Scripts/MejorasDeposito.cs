using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasDeposito : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasCollectorsText;
    public TMP_Text costeOroMejoraMasSpeedText;
    public TMP_Text costeOroMejoraMasCapacidadText;

    public TMP_Text nivelOroMejoraMasCollectorsText;
    public TMP_Text nivelOroMejoraMasSpeedText;
    public TMP_Text nivelOroMejoraMasCapacidadText;

    public double costeOroMejoraMasCollectors;
    public int nivelMejoraMasCollectors;

    public double costeOroMejoraMasVelocidad;
    public int nivelMejoraMasVelocidad;

    public double costeOroMejoraMasCapacidad;
    public int nivelMejoraMasCapacidad;

    public GameObject truck;



    public GameObject particulasMejora;

    public GameObject prestigio;
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
        nivelOroMejoraMasCollectorsText.text = "(" + nivelMejoraMasCollectors.ToString("F0") + ")";
        nivelOroMejoraMasCapacidadText.text = "(" + nivelMejoraMasCapacidad.ToString("F0") + ")";
        if (nivelMejoraMasVelocidad >= 15)
        {
            nivelOroMejoraMasSpeedText.text = "(Max)";
        }
        else
        {
            nivelOroMejoraMasSpeedText.text = "(" + nivelMejoraMasVelocidad.ToString("F0") + ")";
        }

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
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCollectors && nivelMejoraMasCollectors < 20 && GetComponent<Recursos>().cantidadDworfsSinEmpleo >= 1)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-6.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCollectors;
            if (costeOroMejoraMasCollectors == 0)
            {
                costeOroMejoraMasCollectors = 20;
            }
            else
            {
                costeOroMejoraMasCollectors *= 3;
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
            {
                GetComponent<Recursos>().dañoClick /= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
            }
            if (GetComponent<Recursos>().cantidadDworfsSinEmpleoAlmacenados >= 1)
            {
                GetComponent<Recursos>().cantidadDworfsSinEmpleoAlmacenados -= 1;
            }          
            else
            {
                GameObject obj = GameObject.FindGameObjectWithTag("Aldeano");
                if (obj != null)
                {
                    ObjectPool.ReturnObjectToPool(obj);
                }
                GetComponent<Recursos>().cantidadDworfsSinEmpleo -= 1;
            }
            GetComponent<Recursos>().cantidadDworfsCollectors += 1;
            GetComponent<Deposito>().MandarCollectors();
            nivelMejoraMasCollectors += 1;
         
        }
    }
    public void MejoraMasVelocidad()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasVelocidad && nivelMejoraMasVelocidad < 10)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-6.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasVelocidad;
            GetComponent<Recursos>().speedCollectors *= 1.15f;
            GetComponent<Recursos>().speedCollectorsRecolectar /= 1.15f;
            if (nivelMejoraMasVelocidad >= 6)
            {
                costeOroMejoraMasVelocidad *= 2.8f;
            }
            else
            {
                costeOroMejoraMasVelocidad *= 1.8f;
            }
            nivelMejoraMasVelocidad += 1;
        }
    }
    public void MejoraMasCapacidad()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidad)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-6.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidad;
            GetComponent<Recursos>().cargoMaxCollectors *= 1.25f;

            costeOroMejoraMasCapacidad *= 2f;
            nivelMejoraMasCapacidad += 1;
        }
    }


   
}
