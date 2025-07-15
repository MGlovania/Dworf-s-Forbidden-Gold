using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasSilo : MonoBehaviour
{
    public TMP_Text costeOroFuego1Text;
    public TMP_Text costeFeFuego2Text;
    public TMP_Text costeZafiroFuego3Text;

    public TMP_Text nivelOroFuego1Text;
    public TMP_Text nivelFeFuego2Text;
    public TMP_Text nivelZafiroFuego3Text;

    public double costeOroFuego1;
    public int nivelOroFuego1;

    public double costeFeFuego2;
    public int nivelFeFuego2;

    public double costeZafiroFuego3;
    public int nivelZafiroFuego3;

    public GameObject fuego1;
    public GameObject fuego2;
    public GameObject fuego3;
    public GameObject particulasMejora;
    void Start()
    {
        costeOroFuego1 = double.Parse(PlayerPrefs.GetString("CosteOroFuego1", "5000"));
        nivelOroFuego1 = PlayerPrefs.GetInt("NivelOroFuego1");
        costeFeFuego2 = double.Parse(PlayerPrefs.GetString("CosteFeFuego2", "1000"));
        nivelFeFuego2 = PlayerPrefs.GetInt("NivelFeFuego2");
        costeZafiroFuego3 = double.Parse(PlayerPrefs.GetString("CosteZafiroFuego3", "500"));
        nivelZafiroFuego3 = PlayerPrefs.GetInt("NivelZafiroFuego3");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        nivelOroFuego1Text.text = "(" + nivelOroFuego1.ToString("F0") + ")";
        nivelFeFuego2Text.text = "(" + nivelFeFuego2.ToString("F0") + ")";
        nivelZafiroFuego3Text.text = "(" + nivelZafiroFuego3.ToString("F0") + ")";


        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroFuego1", costeOroFuego1.ToString());
        PlayerPrefs.SetInt("NivelOroFuego1", nivelOroFuego1);
        PlayerPrefs.SetString("CosteFeFuego2", costeFeFuego2.ToString());
        PlayerPrefs.SetInt("NivelFeFuego2", nivelFeFuego2);
        PlayerPrefs.SetString("CosteZafiroFuego3", costeZafiroFuego3.ToString());
        PlayerPrefs.SetInt("NivelZafiroFuego3", nivelZafiroFuego3);


 

        if (costeOroFuego1 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroFuego1))));
            var mantissa = (costeOroFuego1 / System.Math.Pow(10, exponent));
            costeOroFuego1Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroFuego1Text.text = costeOroFuego1.ToString("F0");

        }
        if (costeFeFuego2 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeFeFuego2))));
            var mantissa = (costeFeFuego2 / System.Math.Pow(10, exponent));
            costeFeFuego2Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeFeFuego2Text.text = costeFeFuego2.ToString("F0");

        }
        if (costeZafiroFuego3 >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroFuego3))));
            var mantissa = (costeZafiroFuego3 / System.Math.Pow(10, exponent));
            costeZafiroFuego3Text.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroFuego3Text.text = costeZafiroFuego3.ToString("F0");

        }


    }
    void RespawnFuego1()
    {
        ObjectPool.SpawnObject(fuego1, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
    }
    void RespawnFuego2()
    {
        ObjectPool.SpawnObject(fuego2, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
    }
    void RespawnFuego3()
    {
        ObjectPool.SpawnObject(fuego3, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
    }

    public void Fuego1()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroFuego1)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-33.12f, -3, 0), Quaternion.identity);
            ObjectPool.SpawnObject(fuego1, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
            Invoke(nameof(RespawnFuego1), Random.Range(1f, 1.7f));
            Invoke(nameof(RespawnFuego1), Random.Range(2f, 2.7f));
            GetComponent<Recursos>().cantidadOro -= costeOroFuego1;
            nivelOroFuego1 += 1;
        }
    }
    public void Fuego2()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeFeFuego2)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-33.12f, -3, 0), Quaternion.identity);
            ObjectPool.SpawnObject(fuego2, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
            Invoke(nameof(RespawnFuego2), Random.Range(1f, 1.7f));
            Invoke(nameof(RespawnFuego2), Random.Range(2f, 2.7f));
            GetComponent<Recursos>().cantidadFe -= costeFeFuego2;
            nivelFeFuego2 += 1;
        }
    }


    public void Fuego3()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeZafiroFuego3)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-33.12f, -3, 0), Quaternion.identity);
            ObjectPool.SpawnObject(fuego3, new Vector3(Random.Range(-29.7f, -6.8f), -3, 0), Quaternion.identity);
            Invoke(nameof(RespawnFuego3), Random.Range(1f, 1.7f));
            Invoke(nameof(RespawnFuego3), Random.Range(2f, 2.7f));
            GetComponent<Recursos>().cantidadZafiro -= costeZafiroFuego3;
            nivelZafiroFuego3 += 1;
        }
    }
}
