using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasPark : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasAldeanosText;
    public TMP_Text costeZafiroMejoraMasOroText;
    public TMP_Text costeFeMejoraMasZafiroText;

    public TMP_Text nivelOroMejoraMasAldeanosText;
    public TMP_Text nivelZafiroMejoraMasOroText;
    public TMP_Text nivelFeMejoraMasZafiroText;

    public double costeOroMejoraMasAldeanos;
    public int nivelMejoraMasAldeanos;

    public double costeZafiroMejoraMasOro;
    public int nivelZafiroMejoraMasOro;

    public double costeFeMejoraMasZafiro;
    public int nivelFeMejoraMasZafiro;

    public GameObject player;
    public GameObject aldeano;
    public GameObject particulasMejora;
    public GameObject particulasAldeano;
    public GameObject prestigio;
    void Start()
    {
        costeOroMejoraMasAldeanos = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasAldeanos", "250"));
        nivelMejoraMasAldeanos = PlayerPrefs.GetInt("NivelMejoraMasAldeanos");
        costeZafiroMejoraMasOro = double.Parse(PlayerPrefs.GetString("CosteZafiroMejoraMasOro", "150"));
        nivelZafiroMejoraMasOro = PlayerPrefs.GetInt("NivelZafiroMejoraMasOro");
        costeFeMejoraMasZafiro = double.Parse(PlayerPrefs.GetString("CosteFeMejoraMasZafiro", "250"));
        nivelFeMejoraMasZafiro = PlayerPrefs.GetInt("NivelFeMejoraMasZafiro");

        if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraParqueAtraccion >= 1 && player.GetComponent<PJ>().puntoPrestigio <= 0)
        {
            Invoke(nameof(Spawn), GetComponent<Recursos>().timeSpawnAldeanoPark);
        }
      
        Invoke(nameof(Verif), 0.2f);
    }
    void Spawn()
    {
        Invoke(nameof(Spawn), GetComponent<Recursos>().timeSpawnAldeanoPark);
        if (GetComponent<Recursos>().cantidadDworfsSinEmpleo <= 99)
        {
            GetComponent<Recursos>().cantidadDworfsSinEmpleo += 1;          
        }
        else
        {
            GetComponent<Recursos>().cantidadDworfsSinEmpleoAlmacenados += 1;          
        }
        if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasValor >= 1)
        {
            GetComponent<Recursos>().dañoClick *= (1 + 0.2f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoClick);
        }
       GameObject obj = ObjectPool.SpawnObject(aldeano, new Vector3(Random.Range(-15,-8), -3, 0), Quaternion.identity);
        ObjectPool.SpawnObject(particulasAldeano, obj.transform.position, Quaternion.identity);
    }

    void Verif()
    {
        nivelOroMejoraMasAldeanosText.text = "(" + nivelMejoraMasAldeanos.ToString("F0") + ")";
        nivelZafiroMejoraMasOroText.text = "(" + nivelZafiroMejoraMasOro.ToString("F0") + ")";
        nivelFeMejoraMasZafiroText.text = "(" + nivelFeMejoraMasZafiro.ToString("F0") + ")";

        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasAldeanos", costeOroMejoraMasAldeanos.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasAldeanos", nivelMejoraMasAldeanos);
        PlayerPrefs.SetString("CosteZafiroMejoraMasOro", costeZafiroMejoraMasOro.ToString());
        PlayerPrefs.SetInt("NivelZafiroMejoraMasOro", nivelZafiroMejoraMasOro);
        PlayerPrefs.SetString("CosteFeMejoraMasZafiro", costeFeMejoraMasZafiro.ToString());
        PlayerPrefs.SetInt("NivelFeMejoraMasZafiro", nivelFeMejoraMasZafiro);
      
        if (costeOroMejoraMasAldeanos >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasAldeanos))));
            var mantissa = (costeOroMejoraMasAldeanos / System.Math.Pow(10, exponent));
            costeOroMejoraMasAldeanosText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasAldeanosText.text = costeOroMejoraMasAldeanos.ToString("F0");

        }
        if (costeZafiroMejoraMasOro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMejoraMasOro))));
            var mantissa = (costeZafiroMejoraMasOro / System.Math.Pow(10, exponent));
            costeZafiroMejoraMasOroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMejoraMasOroText.text = costeZafiroMejoraMasOro.ToString("F0");

        }
        if (costeFeMejoraMasZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeMejoraMasZafiro))));
            var mantissa = (costeFeMejoraMasZafiro / System.Math.Pow(10, exponent));
            costeFeMejoraMasZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeMejoraMasZafiroText.text = costeFeMejoraMasZafiro.ToString("F0");

        }
       


    }
    public void MejoraMasAldeanos()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasAldeanos && nivelMejoraMasAldeanos < 5)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-24.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasAldeanos;
            GetComponent<Recursos>().timeSpawnAldeanoPark /= 1.2f;
            costeOroMejoraMasAldeanos *= 3.5f;
            nivelMejoraMasAldeanos += 1;
        }

    }
    public void MejoraMasOro()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeZafiroMejoraMasOro)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-24.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadZafiro -= costeZafiroMejoraMasOro;
            GetComponent<Recursos>().valorPiedra *= 1.25f;
            costeZafiroMejoraMasOro *= 3.5f;
            nivelZafiroMejoraMasOro += 1;
        }

    }
    public void MejoraMasZafiro()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeFeMejoraMasZafiro)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-24.9f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadFe -= costeFeMejoraMasZafiro;
            GetComponent<Recursos>().valorZafiro *= 1.25f;
            costeFeMejoraMasZafiro *= 3.5f;
            nivelFeMejoraMasZafiro += 1;
        }

    }
}
