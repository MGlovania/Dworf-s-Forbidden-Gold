using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasCatedral : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasDañoClickText;
    public TMP_Text costeOroMejoraMasProbCritClickText;
    public TMP_Text costeOroMejoraMasDañoCritText;
    public TMP_Text costeOroMejoraMasFeText;
    public TMP_Text costeFeMejoraMasDañoClickText;
    public TMP_Text costeFeMejoraMasDañoDworfsText;
    public TMP_Text costeFeMejoraMasValorOroText;

    public TMP_Text nivelOroMejoraMasDañoClickText;
    public TMP_Text nivelOroMejoraMasProbCritClickText;
    public TMP_Text nivelOroMejoraMasDañoCritText;
    public TMP_Text nivelOroMejoraMasFeText;
    public TMP_Text nivelFeMejoraMasDañoClickText;
    public TMP_Text nivelFeMejoraMasDañoDworfsText;
    public TMP_Text nivelFeMejoraMasValorOroText;

    public double costeOroMejoraMasDañoClick;
    public int nivelMejoraMasDañoClick;

    public double costeOroMejoraMasProbCritClick;
    public int nivelMejoraMasProbCritClick;

    public double costeOroMejoraMasDañoCrit;
    public int nivelMejoraMasDañoCrit;

    public double costeOroMejoraMasFe;
    public int nivelMejoraMasFe;

    public double costeFeMejoraMasDañoClick;
    public int nivelFeMejoraMasDañoClick;

    public double costeFeMejoraMasDañoDworfs;
    public int nivelFeMejoraMasDañoDworfs;

    public double costeFeMejoraMasValorOro;
    public int nivelFeMejoraMasValorOro;



    public GameObject particulasMejora;
    public GameObject prestigio;
    void Start()
    {
        costeOroMejoraMasDañoClick = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasDañoClick", "25"));
        nivelMejoraMasDañoClick = PlayerPrefs.GetInt("NivelMejoraMasDañoClick");
        costeOroMejoraMasProbCritClick = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasProbCritClick", "50"));
        nivelMejoraMasProbCritClick = PlayerPrefs.GetInt("NivelMejoraMasProbCritClick");
        costeOroMejoraMasDañoCrit = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasDañoCrit", "50"));
        nivelMejoraMasDañoCrit = PlayerPrefs.GetInt("NivelMejoraMasDañoCrit");
        costeOroMejoraMasFe = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasFe", "100"));
        nivelMejoraMasFe = PlayerPrefs.GetInt("NivelMejoraMasFe");
        costeFeMejoraMasDañoClick = double.Parse(PlayerPrefs.GetString("CosteFeMejoraMasDañoClick", "100"));
        nivelFeMejoraMasDañoClick = PlayerPrefs.GetInt("NivelFeMejoraMasDañoClick");
        costeFeMejoraMasDañoDworfs = double.Parse(PlayerPrefs.GetString("CosteFeMejoraMasDañoDworfs", "150"));
        nivelFeMejoraMasDañoDworfs = PlayerPrefs.GetInt("NivelFeMejoraMasDañoDworfs");
        costeFeMejoraMasValorOro = double.Parse(PlayerPrefs.GetString("CosteFeMejoraMasValorOro", "200"));
        nivelFeMejoraMasValorOro = PlayerPrefs.GetInt("NivelFeMejoraMasValorOro");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {

        nivelOroMejoraMasDañoClickText.text = "(" + nivelMejoraMasDañoClick.ToString("F0") + ")";
        nivelOroMejoraMasProbCritClickText.text = "(" + nivelMejoraMasProbCritClick.ToString("F0") + ")";
        nivelOroMejoraMasDañoCritText.text = "(" + nivelMejoraMasDañoCrit.ToString("F0") + ")";
        nivelOroMejoraMasFeText.text = "(" + nivelMejoraMasFe.ToString("F0") + ")";
        nivelFeMejoraMasDañoClickText.text = "(" + nivelFeMejoraMasDañoClick.ToString("F0") + ")";
        nivelFeMejoraMasDañoDworfsText.text = "(" + nivelFeMejoraMasDañoDworfs.ToString("F0") + ")";
        nivelFeMejoraMasValorOroText.text = "(" + nivelFeMejoraMasValorOro.ToString("F0") + ")";

        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasDañoClick", costeOroMejoraMasDañoClick.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasDañoClick", nivelMejoraMasDañoClick);
        PlayerPrefs.SetString("CosteOroMejoraMasProbCritClick", costeOroMejoraMasProbCritClick.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasProbCritClick", nivelMejoraMasProbCritClick);
        PlayerPrefs.SetString("CosteOroMejoraMasDañoCrit", costeOroMejoraMasDañoCrit.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasDañoCrit", nivelMejoraMasDañoCrit);
        PlayerPrefs.SetString("CosteOroMejoraMasFe", costeOroMejoraMasFe.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasFe", nivelMejoraMasFe);
        PlayerPrefs.SetString("CosteFeMejoraMasDañoClick", costeFeMejoraMasDañoClick.ToString());
        PlayerPrefs.SetInt("NivelFeMejoraMasDañoClick", nivelFeMejoraMasDañoClick);
        PlayerPrefs.SetString("CosteFeMejoraMasDañoDworfs", costeFeMejoraMasDañoDworfs.ToString());
        PlayerPrefs.SetInt("NivelFeMejoraMasDañoDworfs", nivelFeMejoraMasDañoDworfs);
        PlayerPrefs.SetString("CosteFeMejoraMasValorOro", costeFeMejoraMasValorOro.ToString());
        PlayerPrefs.SetInt("NivelFeMejoraMasValorOro", nivelFeMejoraMasValorOro);
        if (costeOroMejoraMasDañoClick >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasDañoClick))));
            var mantissa = (costeOroMejoraMasDañoClick / System.Math.Pow(10, exponent));
            costeOroMejoraMasDañoClickText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasDañoClickText.text = costeOroMejoraMasDañoClick.ToString("F0");

        }
        if (costeOroMejoraMasProbCritClick >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasProbCritClick))));
            var mantissa = (costeOroMejoraMasProbCritClick / System.Math.Pow(10, exponent));
            costeOroMejoraMasProbCritClickText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasProbCritClickText.text = costeOroMejoraMasProbCritClick.ToString("F0");

        }
        if (costeOroMejoraMasDañoCrit >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasDañoCrit))));
            var mantissa = (costeOroMejoraMasDañoCrit / System.Math.Pow(10, exponent));
            costeOroMejoraMasDañoCritText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasDañoCritText.text = costeOroMejoraMasDañoCrit.ToString("F0");

        }
        if (costeOroMejoraMasFe >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasFe))));
            var mantissa = (costeOroMejoraMasFe / System.Math.Pow(10, exponent));
            costeOroMejoraMasFeText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasFeText.text = costeOroMejoraMasFe.ToString("F0");

        }
        if (costeFeMejoraMasDañoClick >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeMejoraMasDañoClick))));
            var mantissa = (costeFeMejoraMasDañoClick / System.Math.Pow(10, exponent));
            costeFeMejoraMasDañoClickText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeMejoraMasDañoClickText.text = costeFeMejoraMasDañoClick.ToString("F0");

        }
        if (costeFeMejoraMasDañoDworfs >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeMejoraMasDañoDworfs))));
            var mantissa = (costeFeMejoraMasDañoDworfs / System.Math.Pow(10, exponent));
            costeFeMejoraMasDañoDworfsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeMejoraMasDañoDworfsText.text = costeFeMejoraMasDañoDworfs.ToString("F0");

        }
        if (costeFeMejoraMasValorOro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeMejoraMasValorOro))));
            var mantissa = (costeFeMejoraMasValorOro / System.Math.Pow(10, exponent));
            costeFeMejoraMasValorOroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeMejoraMasValorOroText.text = costeFeMejoraMasValorOro.ToString("F0");

        }
    }
    public void MejoraMasClick()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasDañoClick)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasDañoClick;
            GetComponent<Recursos>().dañoClick *= 1.5f;
            costeOroMejoraMasDañoClick *= 1.75f;
            nivelMejoraMasDañoClick += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraMasProbCrit()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasProbCritClick && nivelMejoraMasProbCritClick < 10)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasProbCritClick;
            GetComponent<Recursos>().probCrit += 2;
            costeOroMejoraMasProbCritClick *= 3f;
            nivelMejoraMasProbCritClick += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraMasDañoCrit()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasDañoCrit)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasDañoCrit;
            GetComponent<Recursos>().dañoCrit *= 1.25f;
            costeOroMejoraMasDañoCrit *= 2.25f;
            nivelMejoraMasDañoCrit += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraMasFe()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasFe)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasFe;
            GetComponent<Recursos>().valorDworfsFe += 1;
            costeOroMejoraMasFe *= 2.5f;
            nivelMejoraMasFe += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraFeMasClick()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeFeMejoraMasDañoClick)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeFeMejoraMasDañoClick;
            GetComponent<Recursos>().dañoClick *= 1.5f;
            costeFeMejoraMasDañoClick *= 1.75f;
            nivelFeMejoraMasDañoClick += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraFeMasDañoDworfs()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeFeMejoraMasDañoDworfs)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeFeMejoraMasDañoDworfs;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.25f;
            costeFeMejoraMasDañoDworfs *= 2f;
            nivelFeMejoraMasDañoDworfs += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }
    public void MejoraFeMasValorOro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeFeMejoraMasValorOro)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-19.1f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeFeMejoraMasValorOro;
            GetComponent<Recursos>().valorPiedra *= 1.5f;
            costeFeMejoraMasValorOro *= 2.5f;
            nivelFeMejoraMasValorOro += 1;
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit >= 1)
            {
                GetComponent<Recursos>().dañoCrit *= (1 + 0.1f * prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasDañoCrit);
            }
            if (prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe += prestigio.GetComponent<MejorasPrestigio>().nivelMejoraMasFe;
            }
        }
    }

}
