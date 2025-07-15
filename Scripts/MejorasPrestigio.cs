using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasPrestigio : MonoBehaviour
{
    public TMP_Text costeMejoraMasValorText;
    public TMP_Text costeMejoraMasDañoClickText;
    public TMP_Text costeMejoraMasProbClickCritText;
    public TMP_Text costeMejoraMasDañoCritText;
    public TMP_Text costeMejoraParqueAtraccionText;
    public TMP_Text costeMejoraMasFeText;
    public TMP_Text costeMejoraMasSPText;
    public TMP_Text costeMejoraMasDworfsCasaText;
    public TMP_Text costeMejoraSpeedSuccionText;
    public TMP_Text costeMejoraMasSuccionText;
    public TMP_Text costeMejoraMasCargoTruckText;
    public TMP_Text costeMejoraMasCargoCollectorsText;
    public TMP_Text costeMejoraMasDañoMinerosText;
    public TMP_Text costeMejoraPicosRainbowText;
    public TMP_Text costeMejoraDesbloqZafiroText;
    public TMP_Text costeMejoraDesbloqRGBPotionText;



    public TMP_Text nivelMejoraMasValorText;
    public TMP_Text nivelMejoraMasDañoClickText;
    public TMP_Text nivelMejoraMasProbClickCritText;
    public TMP_Text nivelMejoraMasDañoCritText;
    public TMP_Text nivelMejoraParqueAtraccionText;
    public TMP_Text nivelMejoraMasFeText;
    public TMP_Text nivelMejoraMasSPText;
    public TMP_Text nivelMejoraMasDworfsCasaText;
    public TMP_Text nivelMejoraSpeedSuccionText;
    public TMP_Text nivelMejoraMasSuccionText;
    public TMP_Text nivelMejoraMasCargoTruckText;
    public TMP_Text nivelMejoraMasCargoCollectorsText;
    public TMP_Text nivelMejoraMasDañoMinerosText;
    public TMP_Text nivelMejoraPicosRainbowText;
    public TMP_Text nivelMejoraDesbloqZafiroText;
    public TMP_Text nivelMejoraDesbloqRGBPotionText;


    public double costeMejoraMasValor;
    public double costeMejoraMasDañoClick;
    public double costeMejoraMasProbClickCrit;
    public double costeMejoraMasDañoCrit;
    public double costeMejoraParqueAtraccion;
    public double costeMejoraMasFe;
    public double costeMejoraMasSP;
    public double costeMejoraMasDworfsCasa;
    public double costeMejoraSpeedSuccion;
    public double costeMejoraMasSuccion;
    public double costeMejoraMasCargoTruck;
    public double costeMejoraMasCargoCollectors;
    public double costeMejoraMasDañoMineros;
    public double costeMejoraPicosRainbow;
    public double costeMejoraDesbloqZafiro;
    public double costeMejoraDesbloqRGBPotion;

    public int nivelMejoraMasValor;
    public int nivelMejoraMasDañoClick;
    public int nivelMejoraMasProbClickCrit;
    public int nivelMejoraMasDañoCrit;
    public int nivelMejoraParqueAtraccion;
    public int nivelMejoraMasFe;
    public int nivelMejoraMasSP;
    public int nivelMejoraMasDworfsCasa;
    public int nivelMejoraSpeedSuccion;
    public int nivelMejoraMasSuccion;
    public int nivelMejoraMasCargoTruck;
    public int nivelMejoraMasCargoCollectors;
    public int nivelMejoraMasDañoMineros;
    public int nivelMejoraPicosRainbow;
    public int nivelMejoraDesbloqZafiro;
    public int nivelMejoraDesbloqRGBPotion;

    public GameObject manager;
    public GameObject particulasMejora;

    public GameObject park;

    public GameObject zafiro;
    void Start()
    {
       

        costeMejoraMasValor = double.Parse(PlayerPrefs.GetString("CosteMejoraMasValor", "1"));
        costeMejoraMasDañoClick = double.Parse(PlayerPrefs.GetString("CosteMejoraMasDañoClick", "2"));
        costeMejoraMasProbClickCrit = double.Parse(PlayerPrefs.GetString("CosteMejoraMasProbClickCrit", "3"));
        costeMejoraMasDañoCrit = double.Parse(PlayerPrefs.GetString("CosteMejoraMasDañoCrit", "3"));
        costeMejoraParqueAtraccion = double.Parse(PlayerPrefs.GetString("CosteMejoraParqueAtraccion", "5"));
        costeMejoraMasFe = double.Parse(PlayerPrefs.GetString("CosteMejoraMasFe", "8"));
        costeMejoraMasSP = double.Parse(PlayerPrefs.GetString("CosteMejoraMasSP", "10"));
        costeMejoraMasDworfsCasa = double.Parse(PlayerPrefs.GetString("CosteMejoraMasDworfsCasa", "3"));
        costeMejoraSpeedSuccion = double.Parse(PlayerPrefs.GetString("CosteMejoraSpeedSuccion", "7"));
        costeMejoraMasSuccion = double.Parse(PlayerPrefs.GetString("CosteMejoraMasSuccion", "15"));
        costeMejoraMasCargoTruck = double.Parse(PlayerPrefs.GetString("CosteMejoraMasCargoTruck", "12"));
        costeMejoraMasCargoCollectors = double.Parse(PlayerPrefs.GetString("CosteMejoraMasCargoCollectors", "17"));
        costeMejoraMasDañoMineros = double.Parse(PlayerPrefs.GetString("CosteMejoraMasDañoMineros", "23"));
        costeMejoraPicosRainbow = double.Parse(PlayerPrefs.GetString("CosteMejoraPicosRainbow", "28"));
        costeMejoraDesbloqZafiro = double.Parse(PlayerPrefs.GetString("CosteMejoraDesbloqZafiro", "10"));
        costeMejoraDesbloqRGBPotion = double.Parse(PlayerPrefs.GetString("CosteMejoraDesbloqRGBPotion", "20"));

        nivelMejoraMasValor = PlayerPrefs.GetInt("NivelMejoraMasValor");
        nivelMejoraMasDañoClick = PlayerPrefs.GetInt("NivelMejoraMasDañoClick");
        nivelMejoraMasProbClickCrit = PlayerPrefs.GetInt("NivelMejoraMasProbClickCrit");
        nivelMejoraMasDañoCrit = PlayerPrefs.GetInt("NivelMejoraMasDañoCrit");
        nivelMejoraParqueAtraccion = PlayerPrefs.GetInt("NivelMejoraParqueAtraccion");
        nivelMejoraMasFe = PlayerPrefs.GetInt("NivelMejoraMasFe");
        nivelMejoraMasSP = PlayerPrefs.GetInt("NivelMejoraMasSP");
        nivelMejoraMasDworfsCasa = PlayerPrefs.GetInt("NivelMejoraMasDworfsCasa");
        nivelMejoraSpeedSuccion = PlayerPrefs.GetInt("NivelMejoraSpeedSuccion");
        nivelMejoraMasSuccion = PlayerPrefs.GetInt("NivelMejoraMasSuccion");
        nivelMejoraMasCargoTruck = PlayerPrefs.GetInt("NivelMejoraMasCargoTruck");
        nivelMejoraMasCargoCollectors = PlayerPrefs.GetInt("NivelMejoraMasCargoCollectors");
        nivelMejoraMasDañoMineros = PlayerPrefs.GetInt("NivelMejoraMasDañoMineros");
        nivelMejoraPicosRainbow = PlayerPrefs.GetInt("NivelMejoraPicosRainbow");
        nivelMejoraDesbloqZafiro = PlayerPrefs.GetInt("NivelMejoraDesbloqZafiro");
        nivelMejoraDesbloqRGBPotion = PlayerPrefs.GetInt("NivelMejoraDesbloqRGBPotion");

        if (nivelMejoraParqueAtraccion >= 1)
        {
            park.SetActive(true);
        }
        if (nivelMejoraDesbloqZafiro >= 1)
        {
            zafiro.SetActive(true);
        }

        Invoke(nameof(Verif), 0.2f);
        //   InvokeRepeating(nameof(MejoraMasClickDamage), 5,10);
    }

    void Verif()
    {
        PlayerPrefs.SetString("CosteMejoraMasValor", costeMejoraMasValor.ToString());
        PlayerPrefs.SetString("CosteMejoraMasDañoClick", costeMejoraMasDañoClick.ToString());
        PlayerPrefs.SetString("CosteMejoraMasProbClickCrit", costeMejoraMasProbClickCrit.ToString());
        PlayerPrefs.SetString("CosteMejoraMasDañoCrit", costeMejoraMasDañoCrit.ToString());
        PlayerPrefs.SetString("CosteMejoraParqueAtraccion", costeMejoraParqueAtraccion.ToString());
        PlayerPrefs.SetString("CosteMejoraMasFe", costeMejoraMasFe.ToString());
        PlayerPrefs.SetString("CosteMejoraMasSP", costeMejoraMasSP.ToString());
        PlayerPrefs.SetString("CosteMejoraMasDworfsCasa", costeMejoraMasDworfsCasa.ToString());
        PlayerPrefs.SetString("CosteMejoraSpeedSuccion", costeMejoraSpeedSuccion.ToString());
        PlayerPrefs.SetString("CosteMejoraMasSuccion", costeMejoraMasSuccion.ToString());
        PlayerPrefs.SetString("CosteMejoraMasCargoTruck", costeMejoraMasCargoTruck.ToString());
        PlayerPrefs.SetString("CosteMejoraMasCargoCollectors", costeMejoraMasCargoCollectors.ToString());
        PlayerPrefs.SetString("CosteMejoraMasDañoMineros", costeMejoraMasDañoMineros.ToString());
        PlayerPrefs.SetString("CosteMejoraPicosRainbow", costeMejoraPicosRainbow.ToString());
        PlayerPrefs.SetString("CosteMejoraDesbloqZafiro", costeMejoraDesbloqZafiro.ToString());
        PlayerPrefs.SetString("CosteMejoraDesbloqRGBPotion", costeMejoraDesbloqRGBPotion.ToString());

        PlayerPrefs.SetInt("NivelMejoraMasValor", nivelMejoraMasValor);
        PlayerPrefs.SetInt("NivelMejoraMasDañoClick", nivelMejoraMasDañoClick);
        PlayerPrefs.SetInt("NivelMejoraMasProbClickCrit", nivelMejoraMasProbClickCrit);
        PlayerPrefs.SetInt("NivelMejoraMasDañoCrit", nivelMejoraMasDañoCrit);
        PlayerPrefs.SetInt("NivelMejoraParqueAtraccion", nivelMejoraParqueAtraccion);
        PlayerPrefs.SetInt("NivelMejoraMasFe", nivelMejoraMasFe);
        PlayerPrefs.SetInt("NivelMejoraMasSP", nivelMejoraMasSP);
        PlayerPrefs.SetInt("NivelMejoraMasDworfsCasa", nivelMejoraMasDworfsCasa);
        PlayerPrefs.SetInt("NivelMejoraSpeedSuccion", nivelMejoraSpeedSuccion);
        PlayerPrefs.SetInt("NivelMejoraMasSuccion", nivelMejoraMasSuccion);
        PlayerPrefs.SetInt("NivelMejoraMasCargoTruck", nivelMejoraMasCargoTruck);
        PlayerPrefs.SetInt("NivelMejoraMasCargoCollectors", nivelMejoraMasCargoCollectors);
        PlayerPrefs.SetInt("NivelMejoraMasDañoMineros", nivelMejoraMasDañoMineros);
        PlayerPrefs.SetInt("NivelMejoraPicosRainbow", nivelMejoraPicosRainbow);
        PlayerPrefs.SetInt("NivelMejoraDesbloqZafiro", nivelMejoraDesbloqZafiro);
        PlayerPrefs.SetInt("NivelMejoraDesbloqRGBPotion", nivelMejoraDesbloqRGBPotion);


        Invoke(nameof(Verif), 0.2f);
        nivelMejoraMasValorText.text = "(" + nivelMejoraMasValor.ToString("F0") + ")";
        nivelMejoraMasDañoClickText.text = "(" + nivelMejoraMasDañoClick.ToString("F0") + ")";
        nivelMejoraMasProbClickCritText.text = "(" + nivelMejoraMasProbClickCrit.ToString("F0") + ")";
        nivelMejoraMasDañoCritText.text = "(" + nivelMejoraMasDañoCrit.ToString("F0") + ")";
        nivelMejoraParqueAtraccionText.text = "(" + nivelMejoraParqueAtraccion.ToString("F0") + ")";
        nivelMejoraMasFeText.text = "(" + nivelMejoraMasFe.ToString("F0") + ")";
        nivelMejoraMasSPText.text = "(" + nivelMejoraMasSP.ToString("F0") + ")";
        nivelMejoraMasDworfsCasaText.text = "(" + nivelMejoraMasDworfsCasa.ToString("F0") + ")";
        nivelMejoraSpeedSuccionText.text = "(" + nivelMejoraSpeedSuccion.ToString("F0") + ")";
        nivelMejoraMasSuccionText.text = "(" + nivelMejoraMasSuccion.ToString("F0") + ")";
        nivelMejoraMasCargoTruckText.text = "(" + nivelMejoraMasCargoTruck.ToString("F0") + ")";
        nivelMejoraMasCargoCollectorsText.text = "(" + nivelMejoraMasCargoCollectors.ToString("F0") + ")";
        nivelMejoraMasDañoMinerosText.text = "(" + nivelMejoraMasDañoMineros.ToString("F0") + ")";
        nivelMejoraPicosRainbowText.text = "(" + nivelMejoraPicosRainbow.ToString("F0") + ")";
        nivelMejoraDesbloqZafiroText.text = "(" + nivelMejoraDesbloqZafiro.ToString("F0") + ")";
        nivelMejoraDesbloqRGBPotionText.text = "(" + nivelMejoraDesbloqRGBPotion.ToString("F0") + ")";

        if (costeMejoraMasValor >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasValor))));
            var mantissa = (costeMejoraMasValor / System.Math.Pow(10, exponent));
            costeMejoraMasValorText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasValorText.text = costeMejoraMasValor.ToString("F0");

        }
        if (costeMejoraMasDañoClick >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasDañoClick))));
            var mantissa = (costeMejoraMasDañoClick / System.Math.Pow(10, exponent));
            costeMejoraMasDañoClickText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasDañoClickText.text = costeMejoraMasDañoClick.ToString("F0");

        }
        if (costeMejoraMasProbClickCrit >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasProbClickCrit))));
            var mantissa = (costeMejoraMasProbClickCrit / System.Math.Pow(10, exponent));
            costeMejoraMasProbClickCritText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasProbClickCritText.text = costeMejoraMasProbClickCrit.ToString("F0");

        }
        if (costeMejoraMasDañoCrit >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasDañoCrit))));
            var mantissa = (costeMejoraMasDañoCrit / System.Math.Pow(10, exponent));
            costeMejoraMasDañoCritText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasDañoCritText.text = costeMejoraMasDañoCrit.ToString("F0");

        }
        if (costeMejoraParqueAtraccion >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraParqueAtraccion))));
            var mantissa = (costeMejoraParqueAtraccion / System.Math.Pow(10, exponent));
            costeMejoraParqueAtraccionText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraParqueAtraccionText.text = costeMejoraParqueAtraccion.ToString("F0");

        }
        if (costeMejoraMasFe >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasFe))));
            var mantissa = (costeMejoraMasFe / System.Math.Pow(10, exponent));
            costeMejoraMasFeText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasFeText.text = costeMejoraMasFe.ToString("F0");

        }
        if (costeMejoraMasSP >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasSP))));
            var mantissa = (costeMejoraMasSP / System.Math.Pow(10, exponent));
            costeMejoraMasSPText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasSPText.text = costeMejoraMasSP.ToString("F0");

        }
        if (costeMejoraMasDworfsCasa >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasDworfsCasa))));
            var mantissa = (costeMejoraMasDworfsCasa / System.Math.Pow(10, exponent));
            costeMejoraMasDworfsCasaText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasDworfsCasaText.text = costeMejoraMasDworfsCasa.ToString("F0");

        }
        if (costeMejoraSpeedSuccion >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraSpeedSuccion))));
            var mantissa = (costeMejoraSpeedSuccion / System.Math.Pow(10, exponent));
            costeMejoraSpeedSuccionText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraSpeedSuccionText.text = costeMejoraSpeedSuccion.ToString("F0");

        }
        if (costeMejoraMasSuccion >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasSuccion))));
            var mantissa = (costeMejoraMasSuccion / System.Math.Pow(10, exponent));
            costeMejoraMasSuccionText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasSuccionText.text = costeMejoraMasSuccion.ToString("F0");

        }
        if (costeMejoraMasCargoTruck >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasCargoTruck))));
            var mantissa = (costeMejoraMasCargoTruck / System.Math.Pow(10, exponent));
            costeMejoraMasCargoTruckText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasCargoTruckText.text = costeMejoraMasCargoTruck.ToString("F0");

        }
        if (costeMejoraMasCargoCollectors >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasCargoCollectors))));
            var mantissa = (costeMejoraMasCargoCollectors / System.Math.Pow(10, exponent));
            costeMejoraMasCargoCollectorsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasCargoCollectorsText.text = costeMejoraMasCargoCollectors.ToString("F0");

        }
        if (costeMejoraMasDañoMineros >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraMasDañoMineros))));
            var mantissa = (costeMejoraMasDañoMineros / System.Math.Pow(10, exponent));
            costeMejoraMasDañoMinerosText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraMasDañoMinerosText.text = costeMejoraMasDañoMineros.ToString("F0");

        }
        if (costeMejoraPicosRainbow >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraPicosRainbow))));
            var mantissa = (costeMejoraPicosRainbow / System.Math.Pow(10, exponent));
            costeMejoraPicosRainbowText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraPicosRainbowText.text = costeMejoraPicosRainbow.ToString("F0");

        }
        if (costeMejoraDesbloqZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraDesbloqZafiro))));
            var mantissa = (costeMejoraDesbloqZafiro / System.Math.Pow(10, exponent));
            costeMejoraDesbloqZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraDesbloqZafiroText.text = costeMejoraDesbloqZafiro.ToString("F0");

        }
        if (costeMejoraDesbloqRGBPotion >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeMejoraDesbloqRGBPotion))));
            var mantissa = (costeMejoraDesbloqRGBPotion / System.Math.Pow(10, exponent));
            costeMejoraDesbloqRGBPotionText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeMejoraDesbloqRGBPotionText.text = costeMejoraDesbloqRGBPotion.ToString("F0");

        }
    }
   public void MejoraMasValor()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasValor)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-13.58f, 146.43f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasValor;
            if (nivelMejoraMasValor >= 7)
            {
                costeMejoraMasValor *= 2;
            }
            else
            {
                costeMejoraMasValor += 2;
            }
            manager.GetComponent<Recursos>().valorPiedra *= 1.5f;
            nivelMejoraMasValor += 1;
            if (nivelMejoraMasValor == 1)
            {
                GetComponent<Nodos>().SetLineaValor();
            }
        }
    }
    public void MejoraMasClickDamage()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasDañoClick)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-14.92f, 146.43f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasDañoClick;
            if (nivelMejoraMasValor >= 7)
            {
                costeMejoraMasDañoClick *= 2;
            }
            else
            {
                costeMejoraMasDañoClick += 2;
            }
            nivelMejoraMasDañoClick += 1;
            if (nivelMejoraMasDañoClick == 1)
            {
                GetComponent<Nodos>().SetLineaClickDamage();
            }
        }
    }
    public void MejoraMasCritProb()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasProbClickCrit && nivelMejoraMasProbClickCrit < 9)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.03f, 147.67f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().probCrit += 2;
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasProbClickCrit;
            if (nivelMejoraMasValor >= 7)
            {
                costeMejoraMasProbClickCrit *= 2;
            }
            else
            {
                costeMejoraMasProbClickCrit += 2;
            }
            nivelMejoraMasProbClickCrit += 1;           
        }
    }
    public void MejoraMasCritDamage()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasDañoCrit)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.03f, 147.67f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasDañoCrit;
            if (nivelMejoraMasValor >= 7)
            {
                costeMejoraMasDañoCrit *= 2;
            }
            else
            {
                costeMejoraMasDañoCrit += 2;
            }
            nivelMejoraMasDañoCrit += 1;
        }
    }
    public void MejoraPark()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraParqueAtraccion && nivelMejoraParqueAtraccion <= 0)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-13.6f, 147.67f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraParqueAtraccion;
            park.SetActive(true);
            nivelMejoraParqueAtraccion += 1;
        }
    }
    public void MejoraMasSP()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasSP && nivelMejoraMasSP < 15)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-12.61f, 148.95f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasSP;
            manager.GetComponent<Recursos>().cantidadStarPointsGanadosPorGold *= 2;
            if (nivelMejoraMasSP >= 7)
            {
                costeMejoraMasSP *= 3;
            }
            else if (nivelMejoraMasSP >= 4)
            {
                costeMejoraMasSP *= 2;
            }
            else
            {
                costeMejoraMasSP += 10;
            }
            nivelMejoraMasSP += 1;
        }
    }
    public void MejoraMasFe()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraMasFe)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-14.59f, 148.95f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraMasFe;
            if (nivelMejoraMasFe >= 5)
            {
                costeMejoraMasFe *= 2;
            }
            else
            {
                costeMejoraMasFe += 8;
            }
            nivelMejoraMasFe += 1;
        }
    }
    public void MejoraZafiro()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraDesbloqZafiro && nivelMejoraDesbloqZafiro <= 0)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-13.59f, 145.232f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraDesbloqZafiro;
            zafiro.SetActive(true);
            nivelMejoraDesbloqZafiro += 1;
        }
    }
    public void MejoraPocionRGB()
    {
        AudioManager.instance.PlaySFX("Click");
        if (manager.GetComponent<Recursos>().cantidadStarPoints >= costeMejoraDesbloqRGBPotion && nivelMejoraDesbloqRGBPotion <= 0)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-13.59f, 143.96f, 0), Quaternion.identity);
            manager.GetComponent<Recursos>().cantidadStarPoints -= costeMejoraDesbloqRGBPotion;
            nivelMejoraDesbloqRGBPotion += 1;
        }
    }
}
