using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasMineros : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasMinersText;
    public TMP_Text costeOroMejorMinersMasSpeedText;
    public TMP_Text costeOroMejoraMinersMasDañoText;
    public TMP_Text costeOroMejoraMinersMenosSleepText;
    public TMP_Text costeOroMejoraMinersMasEnergiaText;

    public TMP_Text nivelOroMejoraMasMinersText;
    public TMP_Text nivelOroMejorMinersMasSpeedText;
    public TMP_Text nivelOroMejoraMinersMasDañoText;
    public TMP_Text nivelOroMejoraMinersMenosSleepText;
    public TMP_Text nivelOroMejoraMinersMasEnergiaText;


    public double costeOroMejoraMasMiners;
    public int nivelMejoraMasMiners;

    public double costeOroMejoraMinersMasVelocidad;
    public int nivelMejoraMinersMasVelocidad;

    public double costeOroMejoraMinersMasDaño;
    public int nivelMejoraMinersMasDaño;

    public double costeOroMejoraMinersMenosSleep;
    public int nivelMejoraMinersMenosSleep;

    public double costeOroMejoraMinersMasEnergia;
    public int nivelMejoraMinersMasEnergia;


    public GameObject prefabMiner;
    public GameObject casaMineros;

    public int puntoSpawnearMinerosStart;
    public int puntoQuitarStartSpawn;
    public int puntoSpawnearMinerosSleep;



    public GameObject particulasMejora;

    public GameObject prestigio;
    void Start()
    {
        costeOroMejoraMasMiners = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasMiners", "0"));
        nivelMejoraMasMiners = PlayerPrefs.GetInt("NivelMejoraMasMiners");
        costeOroMejoraMinersMasVelocidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasVelocidad", "40"));
        nivelMejoraMinersMasVelocidad = PlayerPrefs.GetInt("NivelMejoraMinersMasVelocidad");
        costeOroMejoraMinersMasDaño = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasDaño", "40"));
        nivelMejoraMinersMasDaño = PlayerPrefs.GetInt("NivelMejoraMinersMasDaño");
        costeOroMejoraMinersMenosSleep = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMenosSleep", "75"));
        nivelMejoraMinersMenosSleep = PlayerPrefs.GetInt("NivelMejoraMinersMenosSleep");
        costeOroMejoraMinersMasEnergia = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasEnergia", "75"));
        nivelMejoraMinersMasEnergia = PlayerPrefs.GetInt("NivelMejoraMinersMasEnergia");
        Invoke(nameof(Verif), 0.2f);
     
    }
  
    void Verif()
    {
        nivelOroMejoraMasMinersText.text = "(" + nivelMejoraMasMiners.ToString("F0") + ")";
        nivelOroMejoraMinersMasDañoText.text = "(" + nivelMejoraMinersMasDaño.ToString("F0") + ")";
        nivelOroMejoraMinersMenosSleepText.text = "(" + nivelMejoraMinersMenosSleep.ToString("F0") + ")";
        nivelOroMejoraMinersMasEnergiaText.text = "(" + nivelMejoraMinersMasEnergia.ToString("F0") + ")";
        if (nivelMejoraMinersMasVelocidad >= 15)
        {
            nivelOroMejorMinersMasSpeedText.text = "(Max)";
        }
        else
        {
            nivelOroMejorMinersMasSpeedText.text = "(" + nivelMejoraMinersMasVelocidad.ToString("F0") + ")";
        }

        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasMiners", costeOroMejoraMasMiners.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasMiners", nivelMejoraMasMiners);
        PlayerPrefs.SetString("CosteOroMejoraMinersMasVelocidad", costeOroMejoraMinersMasVelocidad.ToString());
        PlayerPrefs.SetInt("NivelMejoraMinersMasVelocidad", nivelMejoraMinersMasVelocidad);
        PlayerPrefs.SetString("CosteOroMejoraMinersMasDaño", costeOroMejoraMinersMasDaño.ToString());
        PlayerPrefs.SetInt("NivelMejoraMinersMasDaño", nivelMejoraMinersMasDaño);
        PlayerPrefs.SetString("CosteOroMejoraMinersMenosSleep", costeOroMejoraMinersMenosSleep.ToString());
        PlayerPrefs.SetInt("NivelMejoraMinersMenosSleep", nivelMejoraMinersMenosSleep);
        PlayerPrefs.SetString("CosteOroMejoraMinersMasEnergia", costeOroMejoraMinersMasEnergia.ToString());
        PlayerPrefs.SetInt("NivelMejoraMinersMasEnergia", nivelMejoraMinersMasEnergia);
        if (costeOroMejoraMasMiners >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasMiners))));
            var mantissa = (costeOroMejoraMasMiners / System.Math.Pow(10, exponent));
            costeOroMejoraMasMinersText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasMinersText.text = costeOroMejoraMasMiners.ToString("F0");

        }
        if (costeOroMejoraMinersMasVelocidad >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMinersMasVelocidad))));
            var mantissa = (costeOroMejoraMinersMasVelocidad / System.Math.Pow(10, exponent));
            costeOroMejorMinersMasSpeedText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejorMinersMasSpeedText.text = costeOroMejoraMinersMasVelocidad.ToString("F0");

        }
        if (costeOroMejoraMinersMasDaño >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMinersMasDaño))));
            var mantissa = (costeOroMejoraMinersMasDaño / System.Math.Pow(10, exponent));
            costeOroMejoraMinersMasDañoText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMinersMasDañoText.text = costeOroMejoraMinersMasDaño.ToString("F0");

        }
        if (costeOroMejoraMinersMenosSleep >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMinersMenosSleep))));
            var mantissa = (costeOroMejoraMinersMenosSleep / System.Math.Pow(10, exponent));
            costeOroMejoraMinersMenosSleepText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMinersMenosSleepText.text = costeOroMejoraMinersMenosSleep.ToString("F0");

        }
        if (costeOroMejoraMinersMasEnergia >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMinersMasEnergia))));
            var mantissa = (costeOroMejoraMinersMasEnergia / System.Math.Pow(10, exponent));
            costeOroMejoraMinersMasEnergiaText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMinersMasEnergiaText.text = costeOroMejoraMinersMasEnergia.ToString("F0");

        }
    }
    public void MejoraMasMiners()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasMiners && nivelMejoraMasMiners < 30 && GetComponent<Recursos>().cantidadDworfsSinEmpleo >= 1)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasMiners;
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
            GetComponent<Recursos>().cantidadDworfsMineros += 1;
            GetComponent<Recursos>().SpawnMineros();
            if (costeOroMejoraMasMiners == 0)
            {
                costeOroMejoraMasMiners = 75;
            }
            else
            {
                costeOroMejoraMasMiners *= 3;
            }
            nivelMejoraMasMiners += 1;
            
        }
    }
    public void MejoraMasVelocidad()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasVelocidad && nivelMejoraMinersMasVelocidad < 10)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasVelocidad;
            GetComponent<Recursos>().speedMiners *= 1.1f;
            GetComponent<Recursos>().speedAtaqueMiners /= 1.2f;
            if (nivelMejoraMinersMasVelocidad >= 6)
            {
                costeOroMejoraMinersMasVelocidad *= 2.8f;
            }
            else
            {
                costeOroMejoraMinersMasVelocidad *= 1.8f;
            }
            nivelMejoraMinersMasVelocidad += 1;
        }
    }
    public void MejoraMasDaño()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasDaño)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasDaño;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.35f;
            costeOroMejoraMinersMasDaño *= 2f;
            nivelMejoraMinersMasDaño += 1;
        }
    }
    public void MejoraMenosSleep()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMenosSleep)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMenosSleep;
            GetComponent<Recursos>().sleepMiners /= 1.2f;
            if (nivelMejoraMinersMenosSleep >= 10)
            {
                costeOroMejoraMinersMenosSleep *= 5f;
            }
            else
            {
                costeOroMejoraMinersMenosSleep *= 2.25f;
            }
            nivelMejoraMinersMenosSleep += 1;
        }
    }
    public void MejoraMasEnergia()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasEnergia)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasEnergia;
            GetComponent<Recursos>().energiaMiners *= 1.2f;
            if (nivelMejoraMinersMasEnergia >= 10)
            {
                costeOroMejoraMinersMasEnergia *= 5f;
            }
            else
            {
                costeOroMejoraMinersMasEnergia *= 2.25f;
            }
            nivelMejoraMinersMasEnergia += 1;
        }
    }


  
}
