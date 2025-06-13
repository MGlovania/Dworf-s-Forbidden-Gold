using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Recursos : MonoBehaviour
{
    public TMP_Text cantidadPepitasActualText;
    public TMP_Text cantidadPepitasMaxText;
    public TMP_Text cantidadOroText;

    public TMP_Text cantidadDworfsSinEmpleoText;

    public float time;
    public GameObject prefab;
    public int puntoCamionEsperando;
    public int puntoSuccion;
    public int cantidadPepitasEnSuelo;
    public double cantidadPepitasActual;
    public double cantidadPepitasMax;
    public double cantidadOro;
    public double cantidadOroTotalObtenido;

    public double cantidadFe;
    public TMP_Text cantidadFeText;
    public GameObject recuadroMostrarFe;

    public double valorDworfsFe;

    public int cantidadTotalDworfs;
    public int cantidadDworfsSinEmpleo;
    public int cantidadDworfsChofer;
    public int cantidadDworfsCollectors;
    public int cantidadDworfsMineros;
    public int cantidadDworfsEnPantalla;
    public int cantidadPicosEnPantalla;
    public GameObject particulasPicos;
    public GameObject particulasPicos2;
    public int cantidadDworfsAlquimistas;
    public GameObject prefabAldeano;

    public double vidaMaxPiedra;
    public double pesoPiedra;
    public double valorPiedra;

    public double cargoMaxCollectors;
    public float speedCollectors;
    public float speedCollectorsRecolectar;

    public double cargoMaxCamion;

    public double dañoClick;
    public int probCrit;
    public float dañoCrit;

    public double dañoDworfsMineros;
    public float speedMiners;
    public float speedAtaqueMiners;
    public float energiaMiners;
    public float sleepMiners;
    public TMP_Text dañoMinersText;
    public TMP_Text sleepMinersText;
    public TMP_Text energiaMinersText;


    public float timeSpawnHadas;
    public float magnitudBuffoHadas;
    public float magnitudBuffoHadasMostrarPorcentaje;
    public float magnitudBuffoMasDañoMostrarPorcentaje;
    public float magnitudBuffoMasValorMostrarPorcentaje;
    public float magnitudBuffoMasGemasMostrarPorcentaje;
    public int puntoBuffoHadaMasDañoDworfs;
    public int puntoBuffoHadaMasDañoDworfsYaConseguido;
    public int puntoBuffoHadaMasValor;
    public int puntoBuffoHadaMasValorYaConseguido;
    public int puntoBuffoHadaMasGemas;
    public int puntoBuffoHadaMasGemasYaConseguido;
    public int puntoBuffoMasAldeanos;
    public int puntoBuffoMasAldeanosYaConseguido;
    public GameObject icono1;
    public GameObject icono2;
    public TMP_Text cantidadBuffoMasDañoText;
    public TMP_Text cantidadBuffoMasValorText;
    public TMP_Text cantidadBuffoMasGemasText;
    public int puntoMejoraObtenerDworfsPorHadas;
    public int probObtenerDworfsPorHada;


    public int cantidadASuccionar;
    public float timeRecharge;
    public float timeSuccion;
    public int permitirSuccion;

    public TMP_Text probar1;
    public TMP_Text probar2;
    public TMP_Text probar3;

    public int pepitaGuardadaParaAumentarEnOtroStack;

    //public GameObject limitePepitasSueloRomper;
    //public GameObject prefabParticulas;
    //public GameObject carga;
    //public int puntoLimitePepitas;


    public TMP_Text cantidadStarPointsText;
    public TMP_Text cantidadStarPointsAlPrestigearText;
    public TMP_Text cantidadStarPointsGanadosPorGoldText;
    public double cantidadStarPoints;
    public double cantidadReqParaStarPoint;
    public double cantidadStarPointsAlPrestigear;
    public double cantidadStarPointsGanadosPorGold;
    public GameObject recuadroStarPoints;


  
    //To everyone seeing not only this but every other script in this game(and my other games), please do not be afraid. im silly. m a mess :3.
    private void Start()
    {
   

        cantidadStarPoints = double.Parse(PlayerPrefs.GetString("CantidadStarPoints", "0"));
        cantidadReqParaStarPoint = double.Parse(PlayerPrefs.GetString("CantidadReqParaStarPoint", "5000"));
       

        permitirSuccion = 1;
        cantidadTotalDworfs = PlayerPrefs.GetInt("CantidadTotalDworfs");
        cantidadDworfsSinEmpleo = PlayerPrefs.GetInt("CantidadDworfsSinEmpleo");
        cantidadDworfsChofer = PlayerPrefs.GetInt("CantidadDworfsChofer");
        cantidadDworfsCollectors = PlayerPrefs.GetInt("CantidadDworfsCollectors");
        cantidadDworfsMineros = PlayerPrefs.GetInt("CantidadDworfsMineros");
        cantidadDworfsAlquimistas = PlayerPrefs.GetInt("CantidadDworfsAlquimistas");
        cantidadOro = double.Parse(PlayerPrefs.GetString("CantidadOro", "444"));
        cantidadFe = double.Parse(PlayerPrefs.GetString("CantidadFe", "550"));
        valorDworfsFe = double.Parse(PlayerPrefs.GetString("ValorDworfsFe", "1"));
        cantidadOroTotalObtenido = double.Parse(PlayerPrefs.GetString("cantidadOroTotalObtenido", "0"));
        speedCollectors = PlayerPrefs.GetFloat("SpeedCollectors");
        speedCollectorsRecolectar = PlayerPrefs.GetFloat("SpeedCollectorsRecolectar");
        cargoMaxCollectors = double.Parse(PlayerPrefs.GetString("CargoMaxCollectors", "10"));
        dañoClick = double.Parse(PlayerPrefs.GetString("DañoClick", "1"));
        probCrit = PlayerPrefs.GetInt("ProbCrit");
        dañoCrit = PlayerPrefs.GetFloat("DañoCrit");
        dañoDworfsMineros = double.Parse(PlayerPrefs.GetString("DañoDworfsMineros", "1"));
        vidaMaxPiedra = double.Parse(PlayerPrefs.GetString("VidaMaxPiedra", "1"));
        pesoPiedra = double.Parse(PlayerPrefs.GetString("PesoPiedra", "1"));
        valorPiedra = double.Parse(PlayerPrefs.GetString("ValorPiedra", "1"));
        cantidadPepitasActual = double.Parse(PlayerPrefs.GetString("CantidadPepitasActual", "0"));
        cantidadPepitasMax = double.Parse(PlayerPrefs.GetString("CantidadPepitasMax", "600"));
        cargoMaxCamion = double.Parse(PlayerPrefs.GetString("CargoMaxCamion", "20"));
        timeSpawnHadas = PlayerPrefs.GetFloat("TimeSpawnHadas");
        magnitudBuffoHadas = PlayerPrefs.GetFloat("MagnitudBuffoHadas");
        speedMiners = PlayerPrefs.GetFloat("SpeedMiners");
        speedAtaqueMiners = PlayerPrefs.GetFloat("SpeedAtaqueMiners");
        energiaMiners = PlayerPrefs.GetFloat("EnergiaMiners");
        sleepMiners = PlayerPrefs.GetFloat("SleepMiners");
        cantidadASuccionar = PlayerPrefs.GetInt("CantidadASuccionar");
        timeRecharge = PlayerPrefs.GetFloat("TimeRecharge");
        timeSuccion = PlayerPrefs.GetFloat("TimeSuccion");
        if (cantidadFe >= 1)
        {
            recuadroMostrarFe.SetActive(true);
        }
        if (dañoCrit <= 0)
        {
            dañoCrit = 2;
        }     
        if (cantidadPepitasMax <= 0)
        {
            cantidadPepitasMax = 600;
        }
        if (cantidadASuccionar <= 0)
        {
            cantidadASuccionar = 5;
        }
        if (timeRecharge <= 0)
        {
            timeRecharge = 3;
        }
        if (timeSuccion <= 0)
        {
            timeSuccion = 0.75f;
        }
        if (speedMiners <= 0)
        {
            speedMiners = 2;
        }
        if (speedAtaqueMiners <= 0)
        {
            speedAtaqueMiners = 2;
        }
        if (energiaMiners <= 0)
        {
            energiaMiners = 30;
        }
        if (sleepMiners <= 0)
        {
            sleepMiners = 13;
        }
        if (timeSpawnHadas <= 0)
        {
            timeSpawnHadas = 240f;
        }     
        if (magnitudBuffoHadas <= 0)
        {
            magnitudBuffoHadas = 1.5f;
        }
        if (speedCollectors <= 0)
        {
            speedCollectors = 2;
        }
        if (speedCollectorsRecolectar <= 0)
        {
            speedCollectorsRecolectar = 1;
        }
        for (int i = 0; i < cantidadDworfsSinEmpleo; i++)
        {
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(Random.Range(-8.7f, -33), -3, 0), Quaternion.identity);
        }
       
  
        Invoke(nameof(Verif), 0.2f);

    }

    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
    void Verif()
    {
        if (cantidadDworfsEnPantalla >= 22)
        {
            particulasPicos2.SetActive(true);
        }
        else
        {
            particulasPicos2.SetActive(false);
        }
        if (cantidadDworfsEnPantalla >= 15)
        {
            particulasPicos.SetActive(true);
        }
        else
        {
            particulasPicos.SetActive(false);
        }
        if (GetComponent<Construir>().puntoCatedralCosntruida >= 1)
        {
            recuadroMostrarFe.SetActive(true);
        }
        if (cantidadOro >= cantidadReqParaStarPoint)
        {
            cantidadReqParaStarPoint += 5000;
            cantidadStarPointsAlPrestigear += cantidadStarPointsGanadosPorGold;
        }
      
        Invoke(nameof(Verif), 0.2f);
       // probar1.text = wit.ToString("F0");
      //  probar2.text = heit.ToString("F0");
      //  probar3.text = speedCollectors.ToString("F0");
        cantidadBuffoMasDañoText.text = "+" + magnitudBuffoMasDañoMostrarPorcentaje.ToString("F0") + "%";
        cantidadBuffoMasValorText.text = "+" + magnitudBuffoMasValorMostrarPorcentaje.ToString("F0") + "%";
        cantidadBuffoMasGemasText.text = "+" + magnitudBuffoMasGemasMostrarPorcentaje.ToString("F0") + "%";
        dañoMinersText.text = dañoDworfsMineros.ToString("F0");
        sleepMinersText.text = sleepMiners.ToString("F0") + "s";
        energiaMinersText.text = energiaMiners.ToString("F0") + "s";

        PlayerPrefs.SetInt("CantidadTotalDworfs", cantidadTotalDworfs);
        PlayerPrefs.SetInt("CantidadDworfsSinEmpleo", cantidadDworfsSinEmpleo);
        PlayerPrefs.SetInt("CantidadDworfsChofer", cantidadDworfsChofer);
        PlayerPrefs.SetInt("CantidadDworfsCollectors", cantidadDworfsCollectors);
        PlayerPrefs.SetInt("CantidadDworfsMineros", cantidadDworfsMineros);
        PlayerPrefs.SetInt("CantidadDworfsAlquimistas", cantidadDworfsAlquimistas);
        PlayerPrefs.SetString("CantidadOro", cantidadOro.ToString());
        PlayerPrefs.SetString("CantidadFe", cantidadFe.ToString());
        PlayerPrefs.SetString("ValorDworfsFe", valorDworfsFe.ToString());
        PlayerPrefs.SetString("cantidadOroTotalObtenido", cantidadOroTotalObtenido.ToString());
        PlayerPrefs.SetFloat("SpeedCollectorsRecolectar", speedCollectorsRecolectar);
        PlayerPrefs.SetFloat("SpeedCollectors", speedCollectors);
        PlayerPrefs.SetString("CargoMaxCollectors", cargoMaxCollectors.ToString());
        PlayerPrefs.SetString("DañoClick", dañoClick.ToString());
        PlayerPrefs.SetString("DañoDworfsMineros", dañoDworfsMineros.ToString());
        PlayerPrefs.SetString("VidaMaxPiedra", vidaMaxPiedra.ToString());
        PlayerPrefs.SetString("PesoPiedra", pesoPiedra.ToString());
        PlayerPrefs.SetString("ValorPiedra", valorPiedra.ToString());
        PlayerPrefs.SetString("CargoMaxCamion", cargoMaxCamion.ToString());
        PlayerPrefs.SetString("CantidadPepitasMax", cantidadPepitasMax.ToString());
        PlayerPrefs.SetFloat("TimeSpawnHadas", timeSpawnHadas);
        PlayerPrefs.SetFloat("MagnitudBuffoHadas", magnitudBuffoHadas);
        PlayerPrefs.SetFloat("SpeedMiners", speedMiners);
        PlayerPrefs.SetFloat("SpeedAtaqueMiners", speedAtaqueMiners);
        PlayerPrefs.SetFloat("EnergiaMiners", energiaMiners);
        PlayerPrefs.SetFloat("SleepMiners", sleepMiners);
        PlayerPrefs.SetInt("CantidadASuccionar", cantidadASuccionar);
        PlayerPrefs.SetFloat("TimeRecharge", timeRecharge);
        PlayerPrefs.SetFloat("TimeSuccion", timeSuccion);
        PlayerPrefs.SetInt("ProbCrit", probCrit);
        PlayerPrefs.SetFloat("DañoCrit", dañoCrit);
        cantidadPepitasActualText.text = cantidadPepitasActual.ToString("F0");
        cantidadPepitasMaxText.text = "/" + cantidadPepitasMax.ToString("F0");
        cantidadDworfsSinEmpleoText.text = cantidadDworfsSinEmpleo.ToString("F0");
        if (cantidadOro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadOro))));
            var mantissa = (cantidadOro / System.Math.Pow(10, exponent));
            cantidadOroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadOroText.text = cantidadOro.ToString("F0");

        }
        if (cantidadFe >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadFe))));
            var mantissa = (cantidadFe / System.Math.Pow(10, exponent));
            cantidadFeText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadFeText.text = cantidadFe.ToString("F0");

        }


    }

    void Update()
    {
      
        if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = 5;
           cantidadOro += 9.9E+10;
           cantidadDworfsSinEmpleo += 3;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1;
        }


    }

}

