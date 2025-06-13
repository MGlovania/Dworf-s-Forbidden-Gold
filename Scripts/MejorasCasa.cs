using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasCasa : MonoBehaviour
{
    public TMP_Text costeOroMejoraMasCapacidadCasa1Text;
    public TMP_Text costeOroMejoraConvertirEnObeliscoCasa1Text;

    public TMP_Text costeOroMejoraMasCapacidadCasa2Text;
    public TMP_Text costeOroMejoraConvertirEnObeliscoCasa2Text;

    public TMP_Text costeOroMejoraMasCapacidadCasa3Text;
    public TMP_Text costeOroMejoraConvertirEnObeliscoCasa3Text;

    public TMP_Text costeOroMejoraObelisco1DañoText;
    public TMP_Text costeOroMejoraObelisco2DañoText;
    public TMP_Text costeOroMejoraObelisco3DañoText;


    public double costeOroMejoraMasCapacidadCasa1;
    public int nivelMejoraMasCapacidadCasa1;
    public GameObject casa1;
    public GameObject casa1lvl2;
    public GameObject casa1lvl3;
    public GameObject casa1lvl4;
    public GameObject casa1lvl5;
    public GameObject casa1lvl6;
    public GameObject casa1lvl7;
    public GameObject casa1lvl8;
    public GameObject casa1lvl9;

    public double costeOroMejoraMasCapacidadCasa2;
    public int nivelMejoraMasCapacidadCasa2;
    public GameObject casa2;
    public GameObject casa2lvl2;
    public GameObject casa2lvl3;
    public GameObject casa2lvl4;
    public GameObject casa2lvl5;
    public GameObject casa2lvl6;
    public GameObject casa2lvl7;
    public GameObject casa2lvl8;
    public GameObject casa2lvl9;

    public double costeOroMejoraMasCapacidadCasa3;
    public int nivelMejoraMasCapacidadCasa3;
    public GameObject casa3;
    public GameObject casa3lvl2;
    public GameObject casa3lvl3;
    public GameObject casa3lvl4;
    public GameObject casa3lvl5;
    public GameObject casa3lvl6;
    public GameObject casa3lvl7;
    public GameObject casa3lvl8;
    public GameObject casa3lvl9;

    public GameObject prefabAldeano;

    public Sprite obelisco;

    public double costeOroMejoraConvertirEnObeliscoCasa1;
    public int nivelMejoraConvertirEnObeliscoCasa1;
    public GameObject quitarRecuadroMejoraCasa1;
    public GameObject ponerBotonAltar1;
    public GameObject quitarBotonCasa1;

    public double costeOroMejoraConvertirEnObeliscoCasa2;
    public int nivelMejoraConvertirEnObeliscoCasa2;
    public GameObject quitarRecuadroMejoraCasa2;
    public GameObject ponerBotonAltar2;
    public GameObject quitarBotonCasa2;

    public double costeOroMejoraConvertirEnObeliscoCasa3;
    public int nivelMejoraConvertirEnObeliscoCasa3;
    public GameObject quitarRecuadroMejoraCasa3;
    public GameObject ponerBotonAltar3;
    public GameObject quitarBotonCasa3;

    public double costeOroMejoraObelisco1Daño;
    public int nivelMejoraObelisco1Daño;

    public double costeOroMejoraObelisco2Daño;
    public int nivelMejoraObelisco2Daño;

    public double costeOroMejoraObelisco3Daño;
    public int nivelMejoraObelisco3Daño;



  
    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraMasCapacidadCasa1 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidadCasa1", "10"));
        nivelMejoraMasCapacidadCasa1 = PlayerPrefs.GetInt("NivelMejoraMasCapacidadCasa1");
        costeOroMejoraConvertirEnObeliscoCasa1 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraConvertirEnObeliscoCasa1", "500"));
        nivelMejoraConvertirEnObeliscoCasa1 = PlayerPrefs.GetInt("NivelMejoraConvertirEnObeliscoCasa1");
        costeOroMejoraMasCapacidadCasa2 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidadCasa2", "750"));
        nivelMejoraMasCapacidadCasa2 = PlayerPrefs.GetInt("NivelMejoraMasCapacidadCasa2");
        costeOroMejoraConvertirEnObeliscoCasa2 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraConvertirEnObeliscoCasa2", "35000"));
        nivelMejoraConvertirEnObeliscoCasa2 = PlayerPrefs.GetInt("NivelMejoraConvertirEnObeliscoCasa2");
        costeOroMejoraMasCapacidadCasa3 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasCapacidadCasa3", "6000"));
        nivelMejoraMasCapacidadCasa3 = PlayerPrefs.GetInt("NivelMejoraMasCapacidadCasa3");
        costeOroMejoraConvertirEnObeliscoCasa3 = double.Parse(PlayerPrefs.GetString("CosteOroMejoraConvertirEnObeliscoCasa3", "300000"));
        nivelMejoraConvertirEnObeliscoCasa3 = PlayerPrefs.GetInt("NivelMejoraConvertirEnObeliscoCasa3");

        costeOroMejoraObelisco1Daño = double.Parse(PlayerPrefs.GetString("CosteOroMejoraObelisco1Daño", "750"));
        nivelMejoraObelisco1Daño = PlayerPrefs.GetInt("NivelMejoraObelisco1Daño");

        costeOroMejoraObelisco2Daño = double.Parse(PlayerPrefs.GetString("CosteOroMejoraObelisco2Daño", "50000"));
        nivelMejoraObelisco2Daño = PlayerPrefs.GetInt("NivelMejoraObelisco2Daño");

        costeOroMejoraObelisco3Daño = double.Parse(PlayerPrefs.GetString("CosteOroMejoraObelisco3Daño", "400000"));
        nivelMejoraObelisco3Daño = PlayerPrefs.GetInt("NivelMejoraObelisco3Daño");

     

        if (nivelMejoraConvertirEnObeliscoCasa1 >= 1)
        {
            quitarBotonCasa1.SetActive(false);
            ponerBotonAltar1.SetActive(true);
            casa1.GetComponent<SpriteRenderer>().sprite = obelisco;
        }
        else
        {
            if (nivelMejoraMasCapacidadCasa1 >= 1)
            {
                casa1lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 2)
            {
                casa1lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 3)
            {
                casa1lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 4)
            {
                casa1lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 5)
            {
                casa1lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 6)
            {
                casa1lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 7)
            {
                casa1lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 8)
            {
                casa1lvl9.SetActive(true);
            }
        }
        if (nivelMejoraConvertirEnObeliscoCasa2 >= 1)
        {
            quitarBotonCasa2.SetActive(false);
            ponerBotonAltar2.SetActive(true);
            casa2.GetComponent<SpriteRenderer>().sprite = obelisco;
        }
        else
        {
            if (nivelMejoraMasCapacidadCasa2 >= 1)
            {
                casa2lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 2)
            {
                casa2lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 3)
            {
                casa2lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 4)
            {
                casa2lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 5)
            {
                casa2lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 6)
            {
                casa2lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 7)
            {
                casa2lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 8)
            {
                casa2lvl9.SetActive(true);
            }
        }
        if (nivelMejoraConvertirEnObeliscoCasa3 >= 1)
        {
            quitarBotonCasa3.SetActive(false);
            ponerBotonAltar3.SetActive(true);
            casa3.GetComponent<SpriteRenderer>().sprite = obelisco;
        }
        else
        {
            if (nivelMejoraMasCapacidadCasa3 >= 1)
            {
                casa3lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 2)
            {
                casa3lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 3)
            {
                casa3lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 4)
            {
                casa3lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 5)
            {
                casa3lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 6)
            {
                casa3lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 7)
            {
                casa3lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 8)
            {
                casa3lvl9.SetActive(true);
            }
        }


        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMasCapacidadCasa1", costeOroMejoraMasCapacidadCasa1.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCapacidadCasa1", nivelMejoraMasCapacidadCasa1);
        PlayerPrefs.SetString("CosteOroMejoraConvertirEnObeliscoCasa1", costeOroMejoraConvertirEnObeliscoCasa1.ToString());
        PlayerPrefs.SetInt("NivelMejoraConvertirEnObeliscoCasa1", nivelMejoraConvertirEnObeliscoCasa1);
        PlayerPrefs.SetString("CosteOroMejoraMasCapacidadCasa2", costeOroMejoraMasCapacidadCasa2.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCapacidadCasa2", nivelMejoraMasCapacidadCasa2);
        PlayerPrefs.SetString("CosteOroMejoraConvertirEnObeliscoCasa2", costeOroMejoraConvertirEnObeliscoCasa2.ToString());
        PlayerPrefs.SetInt("NivelMejoraConvertirEnObeliscoCasa2", nivelMejoraConvertirEnObeliscoCasa2);
        PlayerPrefs.SetString("CosteOroMejoraMasCapacidadCasa3", costeOroMejoraMasCapacidadCasa3.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasCapacidadCasa3", nivelMejoraMasCapacidadCasa3);
        PlayerPrefs.SetString("CosteOroMejoraConvertirEnObeliscoCasa3", costeOroMejoraConvertirEnObeliscoCasa3.ToString());
        PlayerPrefs.SetInt("NivelMejoraConvertirEnObeliscoCasa3", nivelMejoraConvertirEnObeliscoCasa3);

        PlayerPrefs.SetString("CosteOroMejoraObelisco1Daño", costeOroMejoraObelisco1Daño.ToString());
        PlayerPrefs.SetInt("NivelMejoraObelisco1Daño", nivelMejoraObelisco1Daño);

        PlayerPrefs.SetString("CosteOroMejoraObelisco2Daño", costeOroMejoraObelisco2Daño.ToString());
        PlayerPrefs.SetInt("NivelMejoraObelisco2Daño", nivelMejoraObelisco2Daño);

        PlayerPrefs.SetString("CosteOroMejoraObelisco3Daño", costeOroMejoraObelisco3Daño.ToString());
        PlayerPrefs.SetInt("NivelMejoraObelisco3Daño", nivelMejoraObelisco3Daño);

        if (costeOroMejoraMasCapacidadCasa1 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasCapacidadCasa1))));
            var mantissa = (costeOroMejoraMasCapacidadCasa1 / System.Math.Pow(10, exponent));
            costeOroMejoraMasCapacidadCasa1Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasCapacidadCasa1Text.text = costeOroMejoraMasCapacidadCasa1.ToString("F0");

        }
        if (costeOroMejoraConvertirEnObeliscoCasa1 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraConvertirEnObeliscoCasa1))));
            var mantissa = (costeOroMejoraConvertirEnObeliscoCasa1 / System.Math.Pow(10, exponent));
            costeOroMejoraConvertirEnObeliscoCasa1Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraConvertirEnObeliscoCasa1Text.text = costeOroMejoraConvertirEnObeliscoCasa1.ToString("F0");

        }
        if (costeOroMejoraMasCapacidadCasa2 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasCapacidadCasa2))));
            var mantissa = (costeOroMejoraMasCapacidadCasa2 / System.Math.Pow(10, exponent));
            costeOroMejoraMasCapacidadCasa2Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasCapacidadCasa2Text.text = costeOroMejoraMasCapacidadCasa2.ToString("F0");

        }
        if (costeOroMejoraConvertirEnObeliscoCasa2 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraConvertirEnObeliscoCasa2))));
            var mantissa = (costeOroMejoraConvertirEnObeliscoCasa2 / System.Math.Pow(10, exponent));
            costeOroMejoraConvertirEnObeliscoCasa2Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraConvertirEnObeliscoCasa2Text.text = costeOroMejoraConvertirEnObeliscoCasa2.ToString("F0");

        }
        if (costeOroMejoraMasCapacidadCasa3 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasCapacidadCasa3))));
            var mantissa = (costeOroMejoraMasCapacidadCasa3 / System.Math.Pow(10, exponent));
            costeOroMejoraMasCapacidadCasa3Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasCapacidadCasa3Text.text = costeOroMejoraMasCapacidadCasa3.ToString("F0");

        }
        if (costeOroMejoraConvertirEnObeliscoCasa3 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraConvertirEnObeliscoCasa3))));
            var mantissa = (costeOroMejoraConvertirEnObeliscoCasa3 / System.Math.Pow(10, exponent));
            costeOroMejoraConvertirEnObeliscoCasa3Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraConvertirEnObeliscoCasa3Text.text = costeOroMejoraConvertirEnObeliscoCasa3.ToString("F0");

        }
        if (costeOroMejoraObelisco1Daño >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraObelisco1Daño))));
            var mantissa = (costeOroMejoraObelisco1Daño / System.Math.Pow(10, exponent));
            costeOroMejoraObelisco1DañoText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraObelisco1DañoText.text = costeOroMejoraObelisco1Daño.ToString("F0");

        }
        if (costeOroMejoraObelisco2Daño >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraObelisco2Daño))));
            var mantissa = (costeOroMejoraObelisco2Daño / System.Math.Pow(10, exponent));
            costeOroMejoraObelisco2DañoText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraObelisco2DañoText.text = costeOroMejoraObelisco2Daño.ToString("F0");

        }
        if (costeOroMejoraObelisco3Daño >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraObelisco3Daño))));
            var mantissa = (costeOroMejoraObelisco3Daño / System.Math.Pow(10, exponent));
            costeOroMejoraObelisco3DañoText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraObelisco3DañoText.text = costeOroMejoraObelisco3Daño.ToString("F0");

        }
    }

    public void MejoraCasa1()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidadCasa1 && nivelMejoraMasCapacidadCasa1 < 8)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidadCasa1;
            GetComponent<Recursos>().cantidadDworfsSinEmpleo += 2;
            costeOroMejoraMasCapacidadCasa1 *= 2.5f;
            nivelMejoraMasCapacidadCasa1 += 1;
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3,0), Quaternion.identity);
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
            if (nivelMejoraMasCapacidadCasa1 >= 1)
            {
                casa1lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 2)
            {
                casa1lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 3)
            {
                casa1lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 4)
            {
                casa1lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 5)
            {
                casa1lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 6)
            {
                casa1lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 7)
            {
                casa1lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa1 >= 8)
            {
                casa1lvl9.SetActive(true);
            }
        }
    }
    public void MejoraConvertirEnObelisco1()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraConvertirEnObeliscoCasa1 && nivelMejoraMasCapacidadCasa1 < 1)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            casa1.GetComponent<SpriteRenderer>().sprite = obelisco;
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraConvertirEnObeliscoCasa1;
            GetComponent<Recursos>().dañoDworfsMineros *= 2;
            costeOroMejoraConvertirEnObeliscoCasa1 *= 4f;
            nivelMejoraConvertirEnObeliscoCasa1 += 1;
            quitarRecuadroMejoraCasa1.SetActive(false);
        }
    }
    public void MejoraCasa2()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidadCasa2 && nivelMejoraMasCapacidadCasa2 < 8)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidadCasa2;
            GetComponent<Recursos>().cantidadDworfsSinEmpleo += 2;
            costeOroMejoraMasCapacidadCasa2 *= 3f;
            nivelMejoraMasCapacidadCasa2 += 1;
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
            if (nivelMejoraMasCapacidadCasa2 >= 1)
            {
                casa2lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 2)
            {
                casa2lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 3)
            {
                casa2lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 4)
            {
                casa2lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 5)
            {
                casa2lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 6)
            {
                casa2lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 7)
            {
                casa2lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa2 >= 8)
            {
                casa2lvl9.SetActive(true);
            }
        }
    }
    public void MejoraConvertirEnObelisco2()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraConvertirEnObeliscoCasa2 && nivelMejoraMasCapacidadCasa2 < 1)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            casa1.GetComponent<SpriteRenderer>().sprite = obelisco;
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraConvertirEnObeliscoCasa2;
            costeOroMejoraConvertirEnObeliscoCasa2 *= 4f;
            GetComponent<Recursos>().dañoDworfsMineros *= 2;
            nivelMejoraConvertirEnObeliscoCasa2 += 1;
            quitarRecuadroMejoraCasa2.SetActive(false);
        }
    }
    public void MejoraCasa3()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasCapacidadCasa3 && nivelMejoraMasCapacidadCasa3 < 8)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasCapacidadCasa3;
            GetComponent<Recursos>().cantidadDworfsSinEmpleo += 2;
            costeOroMejoraMasCapacidadCasa3 *= 3.5f;
            nivelMejoraMasCapacidadCasa3 += 1;
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(-8.2f, -3, 0), Quaternion.identity);
            if (nivelMejoraMasCapacidadCasa3 >= 1)
            {
                casa3lvl2.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 2)
            {
                casa3lvl3.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 3)
            {
                casa3lvl4.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 4)
            {
                casa3lvl5.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 5)
            {
                casa3lvl6.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 6)
            {
                casa3lvl7.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 7)
            {
                casa3lvl8.SetActive(true);
            }
            if (nivelMejoraMasCapacidadCasa3 >= 8)
            {
                casa3lvl9.SetActive(true);
            }
        }
    }
    public void MejoraConvertirEnObelisco3()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraConvertirEnObeliscoCasa3 && nivelMejoraMasCapacidadCasa3 < 1)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            casa1.GetComponent<SpriteRenderer>().sprite = obelisco;
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraConvertirEnObeliscoCasa3;
            costeOroMejoraConvertirEnObeliscoCasa3 *= 4f;
            GetComponent<Recursos>().dañoDworfsMineros *= 2;
            nivelMejoraConvertirEnObeliscoCasa3 += 1;
            quitarRecuadroMejoraCasa3.SetActive(false);
        }
    }
    public void MejoraObeliscoDaño1()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraObelisco1Daño)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraObelisco1Daño;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.25f;
            costeOroMejoraObelisco1Daño *= 3f;
            nivelMejoraObelisco1Daño += 1;
        }
    }
    public void MejoraObeliscoDaño2()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraObelisco2Daño)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraObelisco2Daño;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.25f;
            costeOroMejoraObelisco2Daño *= 3.5f;
            nivelMejoraObelisco2Daño += 1;
        }
    }
    public void MejoraObeliscoDaño3()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraObelisco3Daño)
        {
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-8.20f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraObelisco3Daño;
            GetComponent<Recursos>().dañoDworfsMineros *= 1.25f;
            costeOroMejoraObelisco3Daño *= 4;
            nivelMejoraObelisco3Daño += 1;
        }
    }

}
