using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MejorasSuction : MonoBehaviour
{
    public TMP_Text costeOroMejoraMenosRechargeText;
    public TMP_Text costeOroMejorMasSpeedText;
    public TMP_Text costeOroMejoraMasSuccionadosText;

    public double costeOroMejoraMenosRecharge;
    public int nivelMejoraMenosRecharge;

    public double costeOroMejoraMasSpeed;
    public int nivelMejoraMasSpeed;

    public double costeOroMejoraMasSuccionados;
    public int nivelMejoraMasSuccionados;



    public GameObject particulasMejora;
    void Start()
    {
        costeOroMejoraMenosRecharge = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMenosRecharge", "10"));
        nivelMejoraMenosRecharge = PlayerPrefs.GetInt("NivelMejoraMenosRecharge");
        costeOroMejoraMasSpeed = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasSpeed", "10"));
        nivelMejoraMasSpeed = PlayerPrefs.GetInt("NivelMejoraMasSpeed");
        costeOroMejoraMasSuccionados = double.Parse(PlayerPrefs.GetString("CosteOroMejoraMasSuccionados", "50"));
        nivelMejoraMasSuccionados = PlayerPrefs.GetInt("NivelMejoraMasSuccionados");
        Invoke(nameof(Verif), 0.2f);
    }

    void Verif()
    {
      
        Invoke(nameof(Verif), 0.2f);
        PlayerPrefs.SetString("CosteOroMejoraMenosRecharge", costeOroMejoraMenosRecharge.ToString());
        PlayerPrefs.SetInt("NivelMejoraMenosRecharge", nivelMejoraMenosRecharge);
        PlayerPrefs.SetString("CosteOroMejoraMasSpeed", costeOroMejoraMasSpeed.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasSpeed", nivelMejoraMasSpeed);
        PlayerPrefs.SetString("CosteOroMejoraMasSuccionados", costeOroMejoraMasSuccionados.ToString());
        PlayerPrefs.SetInt("NivelMejoraMasSuccionados", nivelMejoraMasSuccionados);
        if (costeOroMejoraMenosRecharge >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMenosRecharge))));
            var mantissa = (costeOroMejoraMenosRecharge / System.Math.Pow(10, exponent));
            costeOroMejoraMenosRechargeText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMenosRechargeText.text = costeOroMejoraMenosRecharge.ToString("F0");

        }
        if (costeOroMejoraMasSpeed >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasSpeed))));
            var mantissa = (costeOroMejoraMasSpeed / System.Math.Pow(10, exponent));
            costeOroMejorMasSpeedText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejorMasSpeedText.text = costeOroMejoraMasSpeed.ToString("F0");

        }
        if (costeOroMejoraMasSuccionados >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(costeOroMejoraMasSuccionados))));
            var mantissa = (costeOroMejoraMasSuccionados / System.Math.Pow(10, exponent));
            costeOroMejoraMasSuccionadosText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            costeOroMejoraMasSuccionadosText.text = costeOroMejoraMasSuccionados.ToString("F0");

        }

    }
    public void MejoraMenosRecharge()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMenosRecharge && nivelMejoraMenosRecharge < 30)
        {

            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMenosRecharge;
            GetComponent<Recursos>().timeRecharge /= 1.1f;
            costeOroMejoraMenosRecharge *= 2f;
            nivelMejoraMenosRecharge += 1;
         
        }
    }
    public void MejoraMasSpeed()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasSpeed && nivelMejoraMenosRecharge < 25)
        {

            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasSpeed;
            GetComponent<Recursos>().timeSuccion /= 1.1f;
            costeOroMejoraMasSpeed *= 2f;
            nivelMejoraMenosRecharge += 1;

        }
    }
    public void MejoraMasSuccion()
    {
        if (GetComponent<Recursos>().cantidadOro >= costeOroMejoraMasSuccionados)
        {

            GetComponent<Recursos>().cantidadOro -= costeOroMejoraMasSuccionados;
            GetComponent<Recursos>().cantidadASuccionar += 1;
            costeOroMejoraMasSuccionados *= 3f;
            nivelMejoraMasSuccionados += 1;

        }
    }
}
