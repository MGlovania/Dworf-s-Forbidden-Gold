using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasLaboratorio : MonoBehaviour
{
    public TMP_Text costeOroMejoraHardnessText;
    public TMP_Text costeOroMejoraMasAlquimistasText;
    public TMP_Text costeZafiroMejoraPocionDworfsText;
    public TMP_Text costeZafiroMejoraPocionHardnessText;

    public TMP_Text nivelOroMejoraHardnessText;
    public TMP_Text nivelOroMejoraMasAlquimistasText;
    public TMP_Text nivelZafiroMejoraPocionDworfsText;
    public TMP_Text nivelZafiroMejoraPocionHardnessText;

    public double costeOroMejoraHardness;
    public int nivelMejoraMasHardness;

    public double costeOroMejoraMasAlquimistas;
    public int nivelMejoraMasAlquimistas;

    public double costeZafiroMejoraPocionDworfs;
    public int nivelMejoraPocionDworfs;

    public double costeZafiroMejoraPocionHardness;
    public int nivelMejoraPocionHardness;



    public GameObject particulasMejora;
    public GameObject prefabAlquimistas;
    public GameObject prestigio;
    void Start()
    {
        costeOroMejoraHardness = double.Parse(PlayerPrefs.GetString("CosteOroMejoraHardness", "50"));
        nivelMejoraMasHardness = PlayerPrefs.GetInt("NivelMejoraMasHardness");
        costeOroMejoraMasAlquimistas = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasAlquimistas", "150"));
        nivelMejoraMasAlquimistas = PlayerPrefs.GetInt("NivelMejoraMasAlquimistas");
        costeZafiroMejoraPocionDworfs = double.Parse(PlayerPrefs.GetString("CosteZafiroMejoraPocionDworfs", "50"));
        nivelMejoraPocionDworfs = PlayerPrefs.GetInt("NivelMejoraPocionDworfs");
        costeZafiroMejoraPocionHardness = double.Parse(PlayerPrefs.GetString("CosteZafiroMejoraPocionHardness", "100"));
        nivelMejoraPocionHardness = PlayerPrefs.GetInt("NivelMejoraPocionHardness");
        Invoke(nameof(Verif), 0.2f);
    }
    void Verif()
    {
        nivelOroMejoraHardnessText.text = "(" + nivelMejoraMasHardness.ToString("F0") + ")";
        nivelOroMejoraMasAlquimistasText.text = "(" + nivelMejoraMasAlquimistas.ToString("F0") + ")";
        nivelZafiroMejoraPocionDworfsText.text = "(" + nivelMejoraPocionDworfs.ToString("F0") + ")";
        nivelZafiroMejoraPocionHardnessText.text = "(" + nivelMejoraPocionHardness.ToString("F0") + ")";

        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraHardness", costeOroMejoraHardness.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasHardness", nivelMejoraMasHardness);
        PlayerPrefs.SetString("CosteOroMejoraMasAlquimistas", costeOroMejoraMasAlquimistas.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasAlquimistas", nivelMejoraMasAlquimistas);
        PlayerPrefs.SetString("CosteZafiroMejoraPocionDworfs", costeZafiroMejoraPocionDworfs.ToString());
        PlayerPrefs.SetInt("NivelMejoraPocionDworfs", nivelMejoraPocionDworfs);
        PlayerPrefs.SetString("CosteZafiroMejoraPocionHardness", costeZafiroMejoraPocionHardness.ToString());
        PlayerPrefs.SetInt("NivelMejoraPocionHardness", nivelMejoraPocionHardness);
    
        if (costeOroMejoraHardness >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraHardness))));
            var mantissa = (costeOroMejoraHardness / System.Math.Pow(10, exponent));
            costeOroMejoraHardnessText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraHardnessText.text = costeOroMejoraHardness.ToString("F0");

        }
        if (costeOroMejoraMasAlquimistas >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasAlquimistas))));
            var mantissa = (costeOroMejoraMasAlquimistas / System.Math.Pow(10, exponent));
            costeOroMejoraMasAlquimistasText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasAlquimistasText.text = costeOroMejoraMasAlquimistas.ToString("F0");

        }
        if (costeZafiroMejoraPocionDworfs >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMejoraPocionDworfs))));
            var mantissa = (costeZafiroMejoraPocionDworfs / System.Math.Pow(10, exponent));
            costeZafiroMejoraPocionDworfsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMejoraPocionDworfsText.text = costeZafiroMejoraPocionDworfs.ToString("F0");

        }
        if (costeZafiroMejoraPocionHardness >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeZafiroMejoraPocionHardness))));
            var mantissa = (costeZafiroMejoraPocionHardness / System.Math.Pow(10, exponent));
            costeZafiroMejoraPocionHardnessText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeZafiroMejoraPocionHardnessText.text = costeZafiroMejoraPocionHardness.ToString("F0");

        }
     
       
    }
    public void MejoraMasHardness()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraHardness)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.73f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().cantidadOro -= costeOroMejoraHardness;
            GetComponent<Recursos>().vidaMaxPiedra *= 5;
            GetComponent<Recursos>().pesoPiedra *= 5;
            GetComponent<Recursos>().valorPiedra *= 5;
            if (nivelMejoraMasHardness > 5)
            {
                costeOroMejoraHardness *= 30f;
            }
            else
            {
                costeOroMejoraHardness *= 20;
            }
            nivelMejoraMasHardness += 1;
        }
    }
    public void MejoraMasAlquimistas()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasAlquimistas && GetComponent<Recursos>().cantidadDworfsAlquimistas <= 9 && GetComponent<Recursos>().cantidadDworfsSinEmpleo >= 1)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.73f, -3, 0), Quaternion.identity);
            if (GetComponent<Menus>().puntoDworfSeleccionada >= 1)
            {
                GetComponent<Recursos>().valorDworfsFe *= GetComponent<Recursos>().buffoAlquimistasDworfs;
            }
            if (GetComponent<Menus>().puntoHardnessSeleccionada >= 1)
            {
                GetComponent<Recursos>().valorPiedra *= GetComponent<Recursos>().buffoAlquimistasHardness;
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
            GetComponent<Recursos>().cantidadDworfsAlquimistas += 1;
            GetComponent<Recursos>().SpawnAlquimistas();
        
            costeOroMejoraMasAlquimistas *= 7;
            nivelMejoraMasAlquimistas += 1;
        }
    }
    public void MejoraPocionDworfs()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeZafiroMejoraPocionDworfs)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.73f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().buffoAlquimistasDworfs *= 1.2f;
            costeZafiroMejoraPocionDworfs *= 4;
            nivelMejoraPocionDworfs += 1;
        }
    }
    public void MejoraPocionHardness()
    {
        AudioManager.instance.PlaySFX("Click");
        if (GetComponent<Recursos>().cantidadOro >= costeZafiroMejoraPocionHardness)
        {
            AudioManager.instance.PlaySFX("Mejora");
            ObjectPool.SpawnObject(particulasMejora, new Vector3(-16.73f, -3, 0), Quaternion.identity);
            GetComponent<Recursos>().buffoAlquimistasHardness *= 1.2f;
            costeZafiroMejoraPocionHardness *= 4;
            nivelMejoraPocionHardness += 1;
        }
    }
}
