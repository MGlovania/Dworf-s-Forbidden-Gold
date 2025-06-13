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
    void Start()
    {
        costeOroMejoraMasMiners = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasMiners", "25"));
        nivelMejoraMasMiners = PlayerPrefs.GetInt("NivelMejoraMasMiners");
        costeOroMejoraMinersMasVelocidad = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasVelocidad", "75"));
        nivelMejoraMinersMasVelocidad = PlayerPrefs.GetInt("NivelMejoraMinersMasVelocidad");
        costeOroMejoraMinersMasDaño = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasDaño", "75"));
        nivelMejoraMinersMasDaño = PlayerPrefs.GetInt("NivelMejoraMinersMasDaño");
        costeOroMejoraMinersMenosSleep = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMenosSleep", "100"));
        nivelMejoraMinersMenosSleep = PlayerPrefs.GetInt("NivelMejoraMinersMenosSleep");
        costeOroMejoraMinersMasEnergia = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMinersMasEnergia", "100"));
        nivelMejoraMinersMasEnergia = PlayerPrefs.GetInt("NivelMejoraMinersMasEnergia");
        Invoke(nameof(Verif), 0.2f);
     
    }
    public void MineroSleep()
    {
        Invoke(nameof(Despertar), GetComponent<Recursos>().sleepMiners);
     
    }
    void Despertar()
    {
        ObjectPool.SpawnObject(prefabMiner, casaMineros.transform.position + Vector3.right / 2, Quaternion.identity);
    }
    void Verif()
    {
        if (puntoSpawnearMinerosStart < nivelMejoraMasMiners && puntoQuitarStartSpawn <= 0)
        {
            puntoSpawnearMinerosStart += 1;
            ObjectPool.SpawnObject(prefabMiner, casaMineros.transform.position + Vector3.right / 2, Quaternion.identity);
        }
        else
        {
            puntoQuitarStartSpawn = 1;
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
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasMiners && nivelMejoraMasMiners < 25)
        {

            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasMiners;
            GetComponent<Recursos>().cantidadDworfsSinEmpleo -= 1;
            GetComponent<Recursos>().cantidadDworfsMineros += 1;
            costeOroMejoraMasMiners *= 3;
            nivelMejoraMasMiners += 1;
            ObjectPool.SpawnObject(prefabMiner, casaMineros.transform.position + Vector3.right / 2, Quaternion.identity);
            GameObject obj = GameObject.FindGameObjectWithTag("Aldeano");
            if (obj != null)
            {
                ObjectPool.ReturnObjectToPool(obj);
            }
        }
    }
    public void MejoraMasVelocidad()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasVelocidad && nivelMejoraMinersMasVelocidad < 20)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasVelocidad;
            GetComponent<Recursos>().speedMiners *= 1.1f;
            GetComponent<Recursos>().speedAtaqueMiners /= 1.1f;
            if (nivelMejoraMinersMasVelocidad >= 10)
            {
                costeOroMejoraMinersMasVelocidad *= 5f;
            }
            else
            {
                costeOroMejoraMinersMasVelocidad *= 2.5f;
            }
            nivelMejoraMinersMasVelocidad += 1;
        }
    }
    public void MejoraMasDaño()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasDaño)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasDaño;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.25f;
            costeOroMejoraMinersMasDaño *= 2f;
            nivelMejoraMinersMasDaño += 1;
        }
    }
    public void MejoraMenosSleep()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMenosSleep)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMenosSleep;
            GetComponent<Recursos>().sleepMiners /= 1.1f;
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
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMinersMasEnergia)
        {
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMinersMasEnergia;
            GetComponent<Recursos>().energiaMiners *= 1.1f;
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


    void Update()
    {
        
    }
}
