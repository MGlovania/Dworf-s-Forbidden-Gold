using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasDrills : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasPowerDrillText;
    public TMP_Text costeOroMejoraMasDañoDrillText;
    public TMP_Text costeFeMasDañoDrillText;
    public TMP_Text costeZafiroMasResistenciaDrillText;
    public TMP_Text costeOroMasValorZafiroText;
    public TMP_Text costeZafiroMasDañoAZafiroText;

    public TMP_Text nivelOroMejoraMasPowerDrillText;
    public TMP_Text nivelOroMejoraMasDañoDrillText;
    public TMP_Text nivelFeMasDañoDrillText;
    public TMP_Text nivelZafiroMasResistenciaDrillText;
    public TMP_Text nivelOroMasValorZafiroText;
    public TMP_Text nivelZafiroMasDañoAZafiroText;

    public double costeOroMejoraPowerDrill;
    public int nivelMejoraPowerDrill;

    public double costeOroMejoraMasDañoDrill;
    public int nivelMejoraMasDañoDrill;

    public double costeFeMasDañoDrill;
    public int nivelFeMejoraMasDañoDrill;

    public double costeZafiroMasResistenciaDrill;
    public int nivelZafiroMasResistenciaDrill;

    public double costeOroMasValorZafiro;
    public int nivelOroMasValorZafiro;

    public double costeZafiroMasDañoAZafiro;
    public int nivelZafiroMasDañoAZafiro;


    public GameObject particulasMejora;

    public GameObject prestigio;
    void Start()
    {
        costeOroMejoraPowerDrill = double.Parse(PlayerPrefs.GetString("CosteOroMejoraPowerDrill", "500"));
        nivelMejoraPowerDrill = PlayerPrefs.GetInt("NivelMejoraPowerDrill");
        costeOroMejoraMasDañoDrill = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasDañoDrill", "1500"));
        nivelMejoraMasDañoDrill = PlayerPrefs.GetInt("NivelMejoraMasDañoDrill");
        costeFeMasDañoDrill = double.Parse(PlayerPrefs.GetString("CosteFeMasDañoDrill", "250"));
        nivelFeMejoraMasDañoDrill = PlayerPrefs.GetInt("NivelFeMejoraMasDañoDrill");
        costeZafiroMasResistenciaDrill = double.Parse(PlayerPrefs.GetString("CosteZafiroMasResistenciaDrill", "100"));
        nivelZafiroMasResistenciaDrill = PlayerPrefs.GetInt("NivelZafiroMasResistenciaDrill");

        costeOroMasValorZafiro = double.Parse(PlayerPrefs.GetString("CosteOroMasValorZafiro", "2500"));
        nivelOroMasValorZafiro = PlayerPrefs.GetInt("NivelOroMasValorZafiro");
        costeZafiroMasDañoAZafiro = double.Parse(PlayerPrefs.GetString("CosteZafiroMasDañoAZafiro", "100"));
        nivelZafiroMasDañoAZafiro = PlayerPrefs.GetInt("NivelZafiroMasDañoAZafiro");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        nivelOroMejoraMasPowerDrillText.text = "(" + nivelMejoraPowerDrill.ToString("F0") + ")";
        nivelOroMejoraMasDañoDrillText.text = "(" + nivelMejoraMasDañoDrill.ToString("F0") + ")";
        nivelFeMasDañoDrillText.text = "(" + nivelFeMejoraMasDañoDrill.ToString("F0") + ")";
        nivelZafiroMasResistenciaDrillText.text = "(" + nivelZafiroMasResistenciaDrill.ToString("F0") + ")";

        nivelOroMasValorZafiroText.text = "(" + nivelOroMasValorZafiro.ToString("F0") + ")";
        nivelZafiroMasDañoAZafiroText.text = "(" + nivelZafiroMasDañoAZafiro.ToString("F0") + ")";

        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraPowerDrill", costeOroMejoraPowerDrill.ToString());
        PlayerPrefs.SetInt("NivelMejoraPowerDrill", nivelMejoraPowerDrill);
        PlayerPrefs.SetString("CosteOroMejoraMasDañoDrill", costeOroMejoraMasDañoDrill.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasDañoDrill", nivelMejoraMasDañoDrill);
        PlayerPrefs.SetString("CosteFeMasDañoDrill", costeFeMasDañoDrill.ToString());
        PlayerPrefs.SetInt("NivelFeMejoraMasDañoDrill", nivelFeMejoraMasDañoDrill);
        PlayerPrefs.SetString("CosteZafiroMasResistenciaDrill", costeZafiroMasResistenciaDrill.ToString());
        PlayerPrefs.SetInt("NivelZafiroMasResistenciaDrill", nivelZafiroMasResistenciaDrill);

        PlayerPrefs.SetString("CosteOroMasValorZafiro", costeOroMasValorZafiro.ToString());
        PlayerPrefs.SetInt("NivelOroMasValorZafiro", nivelOroMasValorZafiro);
        PlayerPrefs.SetString("CosteZafiroMasDañoAZafiro", costeZafiroMasDañoAZafiro.ToString());
        PlayerPrefs.SetInt("NivelZafiroMasDañoAZafiro", nivelZafiroMasDañoAZafiro);


        if (costeOroMejoraPowerDrill >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraPowerDrill))));
            var mantissa = (costeOroMejoraPowerDrill / System.Math.Pow(10, exponent));
            costeOroMejoraMasPowerDrillText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasPowerDrillText.text = costeOroMejoraPowerDrill.ToString("F0");

        }
        if (costeOroMejoraMasDañoDrill >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasDañoDrill))));
            var mantissa = (costeOroMejoraMasDañoDrill / System.Math.Pow(10, exponent));
            costeOroMejoraMasDañoDrillText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasDañoDrillText.text = costeOroMejoraMasDañoDrill.ToString("F0");

        }
        if (costeFeMasDañoDrill >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeMasDañoDrill))));
            var mantissa = (costeFeMasDañoDrill / System.Math.Pow(10, exponent));
            costeFeMasDañoDrillText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeMasDañoDrillText.text = costeFeMasDañoDrill.ToString("F0");

        }
        if (costeZafiroMasResistenciaDrill >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMasResistenciaDrill))));
            var mantissa = (costeZafiroMasResistenciaDrill / System.Math.Pow(10, exponent));
            costeZafiroMasResistenciaDrillText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMasResistenciaDrillText.text = costeZafiroMasResistenciaDrill.ToString("F0");

        }

        if (costeOroMasValorZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMasValorZafiro))));
            var mantissa = (costeOroMasValorZafiro / System.Math.Pow(10, exponent));
            costeOroMasValorZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMasValorZafiroText.text = costeOroMasValorZafiro.ToString("F0");

        }
        if (costeZafiroMasDañoAZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMasDañoAZafiro))));
            var mantissa = (costeZafiroMasDañoAZafiro / System.Math.Pow(10, exponent));
            costeZafiroMasDañoAZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMasDañoAZafiroText.text = costeZafiroMasDañoAZafiro.ToString("F0");

        }



    }
    public void MejoraMasDrills()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraPowerDrill && nivelMejoraPowerDrill < 30 && GetComponent<Recursos>().cantidadDworfsSinEmpleo >= 1)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-21.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraPowerDrill;
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
            GetComponent<Recursos>().cantidadDrills += 1;
            costeOroMejoraPowerDrill *= 3;
            nivelMejoraPowerDrill += 1;
            GetComponent<Recursos>().SpawnDrills();
         
        }
    }
    public void MejoraMasDaño()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasDañoDrill)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasDañoDrill;
            GetComponent<Recursos>().dañoDrills *= 1.35f;
            costeOroMejoraMasDañoDrill *= 2.25f;
             nivelMejoraMasDañoDrill += 1;
        }
    }
    public void MejoraMasDañoFe()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadFe >= costeFeMasDañoDrill)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadFe -= costeFeMasDañoDrill;
            GetComponent<Recursos>().dañoDrills *= 1.35f;
            costeFeMasDañoDrill *= 2f;
            nivelFeMejoraMasDañoDrill += 1;
        }
    }
    public void MejoraMasResistenciaZafiro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadZafiro >= costeZafiroMasResistenciaDrill)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadFe -= costeZafiroMasResistenciaDrill;
            GetComponent<Recursos>().energiaDrill *= 1.2f;
            costeZafiroMasResistenciaDrill *= 2f;
            nivelZafiroMasResistenciaDrill += 1;
        }
    }
    public void MejoraMasValorZafiro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadZafiro >= costeOroMasValorZafiro)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMasValorZafiro;
            GetComponent<Recursos>().valorZafiro *= 1.25f;
            costeOroMasValorZafiro *= 2.2f;
            nivelOroMasValorZafiro += 1;
        }
    }
    public void MejoraMasDañoDrillAZafiro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadZafiro >= costeZafiroMasDañoAZafiro)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-9.64f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadZafiro -= costeZafiroMasDañoAZafiro;
            costeZafiroMasDañoAZafiro *= 2;
            nivelZafiroMasDañoAZafiro += 1;
        }
    }

}
