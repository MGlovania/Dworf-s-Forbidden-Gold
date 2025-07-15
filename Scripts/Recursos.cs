using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Recursos : MonoBehaviour
{

    public TMP_Text oroTotalText;
    public TMP_Text feTotalText;
    public TMP_Text zafiroTotalText;
    public TMP_Text starPointsTotalText;

    public TMP_Text clicksTotalText;
    public TMP_Text clickDamageText;
    public TMP_Text critProbText;
    public TMP_Text critDamageText;

    public TMP_Text faithPerDworfText;

    public TMP_Text totalCollectorsText;
    public TMP_Text collectorsCapacityText;
    public TMP_Text collectorsSpeedText;

    public TMP_Text totalRangedMinersText;
    public TMP_Text rangedMinersDamageText;
    public TMP_Text rangedMinersAttackSpeedText;
    public TMP_Text rangedMinersAwakeTimeText;
    public TMP_Text rangedMinersSleepTimeText;

    public TMP_Text totalPowerDrillsText;
    public TMP_Text powerDrillDamageText;
    public TMP_Text powerDrillAttackSpeedText;
    public TMP_Text powerDrillResistanceText;

    public TMP_Text totalAlchemistsText;
    public TMP_Text pocionDworfBuffText;
    public TMP_Text pocionHardnessBuffText;

    public double totalOro;
    public double totalFe;
    public double totalZafiro;
    public double totalStarPoints;

    public float totalClicks;

    public TMP_Text cantidadPepitasActualText;
    public TMP_Text cantidadPepitasMaxText;
    public TMP_Text cantidadOroText;
    public TMP_Text cantidadZafiroText;

    public TMP_Text cantidadDworfsSinEmpleoText;

    public float time;
    public GameObject prefab;
    public int puntoCamionEsperando;
    public int puntoSuccion;
    public int cantidadPepitasEnSuelo;
    public double cantidadPepitasActual;
    public double cantidadPepitasMax;
    public double cantidadOro;
    public double cantidadZafiro;

    public double cantidadFe;
    public TMP_Text cantidadFeText;
    public GameObject recuadroMostrarFe;

    public double valorDworfsFe;

    public int cantidadTotalDworfs;
    public int cantidadDworfsSinEmpleo;
    public int cantidadDworfsSinEmpleoAlmacenados;
    public int cantidadDworfsChofer;
    public int cantidadDworfsCollectors;
    public int cantidadDworfsMineros;
    public int cantidadDworfsMinerosEnPantalla;
    public int cantidadDworfsDurmiendo;
    public int cantidadPicosEnPantalla;
    public int cantidadDworfsAlquimistas;
    public int cantidadDworfsAlquimistasEnPantalla;
    public GameObject prefabAlquimista;
    public GameObject prefabAldeano;
    public int cantidadDrills;
    public int cantidadDrillsEnPantalla;

    public int puntoDestruirDrill;

    public double vidaMaxPiedra;
    public double pesoPiedra;
    public double valorPiedra;

    public double vidaMaxZafiro;
    public double pesoZafiro;
    public double valorZafiro;

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

    public double dañoDrills;
    public float speedAtaqueDrills;
    public float energiaDrill;

    public float buffoAlquimistasDworfs;
    public float buffoAlquimistasHardness;
    public float buffoAlquimistasRGB;

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
    public TMP_Text probar4;

    public int pepitaGuardadaParaAumentarEnOtroStack;

    //public GameObject limitePepitasSueloRomper;
    //public GameObject prefabParticulas;
    //public GameObject carga;
    //public int puntoLimitePepitas;


    public TMP_Text cantidadStarPointsText;
    public TMP_Text cantidadStarPointsAlPrestigearText;
    public TMP_Text cantidadStarPointsGanadosPorGoldText;
    public TMP_Text cantidadGoldReqParaStarPointsText;
    public double cantidadStarPoints;
    public double cantidadReqParaStarPoint;
    public double cantidadStarPointsAlPrestigear;
    public double cantidadStarPointsGanadosPorGold;
    public GameObject recuadroStarPoints;
    public GameObject recuadroStarPointsTotal;
    public int puntoMostrarRecuadroStarPoints;


    public GameObject animMinero;



    public GameObject piedra;
    public GameObject pico;

    public GameObject drills;
    public GameObject drillsZafiro;

    public GameObject menuInfoTotalZafiroMostrar;
    public GameObject menuInfoTotalStarPointsMostrar;
    public GameObject menuInfoRangedMinersMostrar;
    public GameObject menuInfoPowerDrillsMostrar;
    public GameObject menuInfoAlchemistMostrar;

    public int puntoColliderSonidoPiedra;
    public int puntoColliderSonidoZafiroYTal;
    public int puntoColliderSonidoCentro;
    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider musicSlider2;
    public Slider sfxSlider2;
    public float volumenMusic;
    public float volumenSFX;
    public int puntoPrimeraVezMusic;
    public int puntoPrimeraVezSFX;
    public int puntoOst1;
    public int puntoOst2;
    public int puntoOst3;


    public int range;


    public GameObject fuego1;
    public GameObject fuego2;
    public GameObject fuego3;

    public float timeSpawnAldeanoPark;
    //Silly and messy code :3(all the code in ts, not just this script);
    private void Start()
    {

        volumenMusic = PlayerPrefs.GetFloat("VolumenMusic");
        volumenSFX = PlayerPrefs.GetFloat("VolumenSFX");
        puntoPrimeraVezMusic = PlayerPrefs.GetInt("PuntoPrimeraVezMusic");
        puntoPrimeraVezSFX = PlayerPrefs.GetInt("PuntoPrimeraVezSFX");
        if (puntoPrimeraVezMusic >= 1)
        {
            AudioManager.instance.MusicVolume(volumenMusic);
            musicSlider.value = volumenMusic;
            musicSlider2.value = volumenMusic;
        }
        if (puntoPrimeraVezSFX >= 1)
        {
            AudioManager.instance.SFXVolume(volumenSFX);
            sfxSlider.value = volumenSFX;
            sfxSlider2.value = volumenSFX;
        }

        cantidadStarPoints = double.Parse(PlayerPrefs.GetString("CantidadStarPoints", "0"));
        cantidadStarPointsGanadosPorGold = double.Parse(PlayerPrefs.GetString("CantidadStarPointsGanadosPorGold", "1"));
        cantidadReqParaStarPoint = double.Parse(PlayerPrefs.GetString("CantidadReqParaStarPoint", "1000"));
        cantidadStarPointsAlPrestigear = double.Parse(PlayerPrefs.GetString("CantidadStarPointsAlPrestigear", "0"));
        puntoMostrarRecuadroStarPoints = PlayerPrefs.GetInt("PuntoMostrarRecuadroStarPoints");

        totalOro = double.Parse(PlayerPrefs.GetString("TotalOro", "0"));
        totalFe = double.Parse(PlayerPrefs.GetString("TotalFe", "0"));
        totalZafiro = double.Parse(PlayerPrefs.GetString("TotalZafiro", "0"));
        totalStarPoints = double.Parse(PlayerPrefs.GetString("TotalStarPoints", "0"));
        totalClicks = PlayerPrefs.GetFloat("TotalClicks");



        permitirSuccion = 1;
        cantidadTotalDworfs = PlayerPrefs.GetInt("CantidadTotalDworfs");
        cantidadDworfsSinEmpleo = PlayerPrefs.GetInt("CantidadDworfsSinEmpleo");
        cantidadDworfsSinEmpleoAlmacenados = PlayerPrefs.GetInt("CantidadDworfsSinEmpleoAlmacenados");
        cantidadDworfsChofer = PlayerPrefs.GetInt("CantidadDworfsChofer");
        cantidadDworfsCollectors = PlayerPrefs.GetInt("CantidadDworfsCollectors");
        cantidadDworfsMineros = PlayerPrefs.GetInt("CantidadDworfsMineros");
        cantidadDworfsAlquimistas = PlayerPrefs.GetInt("CantidadDworfsAlquimistas");
        cantidadOro = double.Parse(PlayerPrefs.GetString("CantidadOro", "1"));
        cantidadFe = double.Parse(PlayerPrefs.GetString("CantidadFe", "0"));
        cantidadZafiro = double.Parse(PlayerPrefs.GetString("CantidadZafiro", "0"));
        valorDworfsFe = double.Parse(PlayerPrefs.GetString("ValorDworfsFe", "1"));
        speedCollectors = PlayerPrefs.GetFloat("SpeedCollectors");
        speedCollectorsRecolectar = PlayerPrefs.GetFloat("SpeedCollectorsRecolectar");
        cargoMaxCollectors = double.Parse(PlayerPrefs.GetString("CargoMaxCollectors", "10"));
        dañoClick = double.Parse(PlayerPrefs.GetString("DañoClick", "1"));
        probCrit = PlayerPrefs.GetInt("ProbCrit");
        dañoCrit = PlayerPrefs.GetFloat("DañoCrit");
        dañoDworfsMineros = double.Parse(PlayerPrefs.GetString("DañoDworfsMineros", "1"));
        dañoDrills = double.Parse(PlayerPrefs.GetString("DañoDrills", "10"));
        speedAtaqueDrills = PlayerPrefs.GetFloat("SpeedAtaqueDrills");
        energiaDrill = PlayerPrefs.GetFloat("EnergiaDrill");
        vidaMaxPiedra = double.Parse(PlayerPrefs.GetString("VidaMaxPiedra", "1"));
        pesoPiedra = double.Parse(PlayerPrefs.GetString("PesoPiedra", "1"));
        valorPiedra = double.Parse(PlayerPrefs.GetString("ValorPiedra", "1"));
        vidaMaxZafiro = double.Parse(PlayerPrefs.GetString("VidaMaxZafiro", "10000"));
        pesoZafiro = double.Parse(PlayerPrefs.GetString("PesoZafiro", "25"));
        valorZafiro = double.Parse(PlayerPrefs.GetString("ValorZafiro", "1"));
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
        buffoAlquimistasDworfs = PlayerPrefs.GetFloat("BuffoAlquimistasDworfs");
        buffoAlquimistasHardness = PlayerPrefs.GetFloat("BuffoAlquimistasHardness");
        buffoAlquimistasRGB = PlayerPrefs.GetFloat("BuffoAlquimistasRGB");
        timeSpawnAldeanoPark = PlayerPrefs.GetFloat("TimeSpawnAldeanoPark");

        vidaMaxZafiro = 100;
        vidaMaxPiedra = 10;
        if (timeSpawnAldeanoPark <= 0)
        {
            timeSpawnAldeanoPark = 240;
        }
        if (buffoAlquimistasDworfs <= 0)
        {
            buffoAlquimistasDworfs = 1.2f;
        }
        if (buffoAlquimistasHardness <= 0)
        {
            buffoAlquimistasHardness = 1.2f;
        }
        if (buffoAlquimistasRGB <= 0)
        {
            buffoAlquimistasRGB = 1.2f;
        }
        if (energiaDrill <= 0)
        {
            energiaDrill = 6;
        }
        if (speedAtaqueDrills <= 0)
        {
            speedAtaqueDrills = 0.5f;
        }
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
            cantidadASuccionar = 10;
        }
        if (timeRecharge <= 0)
        {
            timeRecharge = 2;
        }
        if (timeSuccion <= 0)
        {
            timeSuccion = 0.6f;
        }
        if (speedMiners <= 0)
        {
            speedMiners = 1;
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
            speedCollectors = 2.25f;
        }
        if (speedCollectorsRecolectar <= 0)
        {
            speedCollectorsRecolectar = 0.6f;
        }
        for (int i = 0; i < cantidadDworfsSinEmpleo; i++)
        {
            ObjectPool.SpawnObject(prefabAldeano, new Vector3(Random.Range(-8.7f, -33), -3, 0), Quaternion.identity);
        }
        cantidadDrills = 0;
        cantidadDworfsAlquimistas = 1;
        Invoke(nameof(VerifEsperarAQueCarguenOtrosScripts), 0.5f);


        Invoke(nameof(Verif), 0.2f);
        Invoke(nameof(ActualizarStats), 2);
        Invoke(nameof(SpawnMineros), 1f);    
        Invoke(nameof(SpawnAlquimistas), 1f);
        Invoke(nameof(ConseguirFe), 3f);
        Invoke(nameof(ActualizarDañoClickAdicionalPrestigio), 2f);

        Invoke(nameof(Musica), 1f);

    }
    void VerifEsperarAQueCarguenOtrosScripts()
    {

        if (GetComponent<Menus>().puntoPiedraGoldSeleccionada >= 1)
        {
            Invoke(nameof(SpawnDrills), 1f);
        }
        if (GetComponent<Menus>().puntoPiedraZafiroSeleccionada >= 1)
        {
            Invoke(nameof(SpawnDrillsZafiro), 1f);
        }
    }


    void Musica()
    {
        range = Random.Range(0, 3);
        if (range == 0)
        {
            AudioManager.instance.PlayMusic("Ost1");
            puntoOst1 = 1;
            Invoke(nameof(MusicaSiguiente), 85f);
        }
        if (range == 1)
        {
            AudioManager.instance.PlayMusic("Ost2");
            puntoOst2 = 1;
            Invoke(nameof(MusicaSiguiente), 96f);
        }
        else
        {
            AudioManager.instance.PlayMusic("Ost3");
            puntoOst3 = 1;
            Invoke(nameof(MusicaSiguiente), 111f);
        }
    }
    void MusicaSiguiente()
    {
        if (puntoOst1 >= 1)
        {
            Invoke(nameof(MusicaSiguiente), 96f);
            puntoOst1 = 0;
            puntoOst2 = 1;
            AudioManager.instance.PlayMusic("Ost2");
        }
        else if (puntoOst2 >= 1)
        {
            Invoke(nameof(MusicaSiguiente), 111f);
            puntoOst2 = 0;
            puntoOst3 = 1;
            AudioManager.instance.PlayMusic("Ost3");
        }
        else
        {
            Invoke(nameof(MusicaSiguiente), 85f);
            puntoOst3 = 0;
            puntoOst1 = 1;
            AudioManager.instance.PlayMusic("Ost1");
        }
    }
    public void MusicVolume()
    {
        AudioManager.instance.PlaySFX("Click");
        AudioManager.instance.MusicVolume(musicSlider.value / 10);
        volumenMusic = musicSlider.value;
        musicSlider2.value = musicSlider.value;
        PlayerPrefs.SetFloat("VolumenMusic", volumenMusic);
        puntoPrimeraVezMusic = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezMusic", puntoPrimeraVezMusic);
    }
    public void SFXVolume()
    {
        AudioManager.instance.SFXVolume(sfxSlider.value / 10);
        volumenSFX = sfxSlider.value;
        sfxSlider2.value = sfxSlider.value;
        PlayerPrefs.SetFloat("VolumenSFX", volumenSFX);
        puntoPrimeraVezSFX = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezSFX", puntoPrimeraVezSFX);
        AudioManager.instance.PlaySFX("Click");
    }
    public void MusicVolume2()
    {
        AudioManager.instance.PlaySFX("Click");
        AudioManager.instance.MusicVolume(musicSlider2.value / 10);
        volumenMusic = musicSlider2.value;
        musicSlider.value = musicSlider2.value;
        PlayerPrefs.SetFloat("VolumenMusic", volumenMusic);
        puntoPrimeraVezMusic = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezMusic", puntoPrimeraVezMusic);
    }
    public void SFXVolume2()
    {
        AudioManager.instance.SFXVolume(sfxSlider2.value / 10);
        volumenSFX = sfxSlider2.value;
        sfxSlider.value = sfxSlider2.value;
        PlayerPrefs.SetFloat("VolumenSFX", volumenSFX);
        puntoPrimeraVezSFX = 1;
        PlayerPrefs.SetInt("PuntoPrimeraVezSFX", puntoPrimeraVezSFX);
        AudioManager.instance.PlaySFX("Click");
    }
    void ActualizarDañoClickAdicionalPrestigio()
    {
        Invoke(nameof(ActualizarDañoClickAdicionalPrestigio), 2f);
    }
    void ConseguirFe()
    {
        Invoke(nameof(ConseguirFe), 3f);
        if (cantidadDworfsSinEmpleoAlmacenados >= 1)
        {
            cantidadFe += valorDworfsFe * cantidadDworfsSinEmpleoAlmacenados;
            totalFe += valorDworfsFe * cantidadDworfsSinEmpleoAlmacenados;
        }
      
    }
    public void MineroSleep()
    {
        Invoke(nameof(Despertar), GetComponent<Recursos>().sleepMiners);

    }
    void Despertar()
    {
        cantidadDworfsDurmiendo -= 1;
        SpawnMineros();
    }
    void DañarPico()
    {
       
        piedra.GetComponent<Piedra>().DañoPico();
        if (puntoColliderSonidoPiedra >= 1)
        {
            AudioManager.instance.PlaySFX("PicoDaño");
        }
    }
    void DañarMineros()
    { 
       if(cantidadDworfsMinerosEnPantalla >= 1)
        {
            Invoke(nameof(DañarMineros), speedAtaqueMiners);
            ObjectPool.SpawnObject(pico, new Vector3(Random.Range(2.8f, 3), -2.77f, 0), Quaternion.Euler(new Vector3(0,0,-21.4f)));
            Invoke(nameof(DañarPico), 1.3f);
        }
    }
    public void SpawnMineros()
    {
        if ((cantidadDworfsMinerosEnPantalla + cantidadDworfsDurmiendo) < cantidadDworfsMineros)
        {
            cantidadDworfsMinerosEnPantalla += 1;
            GameObject obj = ObjectPool.SpawnObject(animMinero, new Vector3(Random.Range(-8.5f, -9.1f), -3, 0), Quaternion.identity);
            obj.GetComponent<Animator>().speed = speedMiners;
            obj.GetComponent<ReturnObj>().time = 7 / speedMiners;
            Invoke(nameof(DañarMineros), 7.2f / speedMiners);
            Invoke(nameof(SpawnMineros), 0.25f);
        }      
    }
    public void SpawnDrills()
    {
        if (cantidadDrillsEnPantalla < cantidadDrills)
        {
            cantidadDrillsEnPantalla += 1;
            GameObject obj = ObjectPool.SpawnObject(drills, new Vector3(Random.Range(7.88f, 8.21f), -2.56f, 0), Quaternion.identity);
            Invoke(nameof(SpawnDrills), 0.15f);
        }
    }
    public void SpawnDrillsZafiro()
    {
        if (cantidadDrillsEnPantalla < cantidadDrills)
        {
            cantidadDrillsEnPantalla += 1;
            GameObject obj = ObjectPool.SpawnObject(drillsZafiro, new Vector3(Random.Range(-4.76f, -4.34f), -2.56f, 0), Quaternion.identity);
            Invoke(nameof(SpawnDrillsZafiro), 0.15f);
        }
    }
    public void SpawnAlquimistas()
    {
        if (cantidadDworfsAlquimistasEnPantalla < cantidadDworfsAlquimistas)
        {
            cantidadDworfsAlquimistasEnPantalla += 1;
            GameObject obj = ObjectPool.SpawnObject(prefabAlquimista, new Vector3(Random.Range(-14.8f, -18.25f), -3.16f, 0), Quaternion.identity);
            Invoke(nameof(SpawnAlquimistas), 0.25f);
        }
    }
    public void OpenLink(string link)
    {
        Application.OpenURL(link);
    }
    void Verif()
    {
        if (dañoClick <= 0)
        {
            dañoClick = 1;
        }
        if (cantidadDworfsMinerosEnPantalla <= 0)
        {
            cantidadDworfsMinerosEnPantalla = 0;
        }
        if (cantidadDrillsEnPantalla <= 0)
        {
            cantidadDrillsEnPantalla = 0;
        }
        if (cantidadDworfsAlquimistasEnPantalla <= 0)
        {
            cantidadDworfsAlquimistasEnPantalla = 0;
        }
        if (GetComponent<Construir>().puntoCatedralCosntruida >= 1)
        {
            recuadroMostrarFe.SetActive(true);
        }
        if (cantidadOro >= cantidadReqParaStarPoint)
        {
            cantidadReqParaStarPoint *= 1.2f;
            cantidadStarPointsAlPrestigear += cantidadStarPointsGanadosPorGold;
        }
        if (puntoMostrarRecuadroStarPoints >= 1 && recuadroStarPointsTotal.activeSelf != true)
        {
            recuadroStarPointsTotal.SetActive(true);
        }

        Invoke(nameof(Verif), 0.2f);

       probar1.text = (1f / Time.deltaTime).ToString("F2");
       probar2.text = cantidadReqParaStarPoint.ToString("F0");
        probar3.text = cantidadStarPoints.ToString("F0");
        probar4.text = valorZafiro.ToString("F2");

        cantidadBuffoMasDañoText.text = "+" + magnitudBuffoMasDañoMostrarPorcentaje.ToString("F0") + "%";
        cantidadBuffoMasValorText.text = "+" + magnitudBuffoMasValorMostrarPorcentaje.ToString("F0") + "%";
        cantidadBuffoMasGemasText.text = "+" + magnitudBuffoMasGemasMostrarPorcentaje.ToString("F0") + "%";
        dañoMinersText.text = dañoDworfsMineros.ToString("F0");
        sleepMinersText.text = sleepMiners.ToString("F0") + "s";
        energiaMinersText.text = energiaMiners.ToString("F0") + "s";

        PlayerPrefs.SetString("TotalOro", totalOro.ToString());
        PlayerPrefs.SetString("TotalFe", totalFe.ToString());
        PlayerPrefs.SetString("TotalZafiro", totalZafiro.ToString());
        PlayerPrefs.SetString("TotalStarPoints", totalStarPoints.ToString());
        PlayerPrefs.SetFloat("TotalClicks", totalClicks);
        PlayerPrefs.SetString("CantidadStarPointsGanadosPorGold", cantidadStarPointsGanadosPorGold.ToString());
        PlayerPrefs.SetString("CantidadStarPointsAlPrestigear", cantidadStarPointsAlPrestigear.ToString());
        PlayerPrefs.SetString("CantidadStarPoints", cantidadStarPoints.ToString());
        PlayerPrefs.SetString("CantidadReqParaStarPoint", cantidadReqParaStarPoint.ToString());
        PlayerPrefs.SetInt("PuntoMostrarRecuadroStarPoints", puntoMostrarRecuadroStarPoints);

        PlayerPrefs.SetInt("CantidadTotalDworfs", cantidadTotalDworfs);
        PlayerPrefs.SetInt("CantidadDworfsSinEmpleo", cantidadDworfsSinEmpleo);
        PlayerPrefs.SetInt("CantidadDworfsSinEmpleoAlmacenados", cantidadDworfsSinEmpleoAlmacenados);
        PlayerPrefs.SetInt("CantidadDworfsChofer", cantidadDworfsChofer);
        PlayerPrefs.SetInt("CantidadDworfsCollectors", cantidadDworfsCollectors);
        PlayerPrefs.SetInt("CantidadDworfsMineros", cantidadDworfsMineros);
        PlayerPrefs.SetInt("CantidadDworfsAlquimistas", cantidadDworfsAlquimistas);
        PlayerPrefs.SetString("CantidadOro", cantidadOro.ToString());
        PlayerPrefs.SetString("CantidadFe", cantidadFe.ToString());
        PlayerPrefs.SetString("CantidadZafiro", cantidadZafiro.ToString());
        PlayerPrefs.SetString("ValorDworfsFe", valorDworfsFe.ToString());
        PlayerPrefs.SetFloat("SpeedCollectorsRecolectar", speedCollectorsRecolectar);
        PlayerPrefs.SetFloat("SpeedCollectors", speedCollectors);
        PlayerPrefs.SetString("CargoMaxCollectors", cargoMaxCollectors.ToString());
        PlayerPrefs.SetString("DañoClick", dañoClick.ToString());
        PlayerPrefs.SetString("DañoDworfsMineros", dañoDworfsMineros.ToString());
        PlayerPrefs.SetString("DañoDrills", dañoDrills.ToString());
        PlayerPrefs.SetFloat("SpeedAtaqueDrills", speedAtaqueDrills);
        PlayerPrefs.SetFloat("EnergiaDrill", energiaDrill);
        PlayerPrefs.SetString("VidaMaxPiedra", vidaMaxPiedra.ToString());
        PlayerPrefs.SetString("PesoPiedra", pesoPiedra.ToString());
        PlayerPrefs.SetString("ValorPiedra", valorPiedra.ToString());
        PlayerPrefs.SetString("VidaMaxZafiro", vidaMaxZafiro.ToString());
        PlayerPrefs.SetString("PesoZafiro", pesoZafiro.ToString());
        PlayerPrefs.SetString("ValorZafiro", valorZafiro.ToString());
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
        PlayerPrefs.SetFloat("BuffoAlquimistasDworfs", buffoAlquimistasDworfs);
        PlayerPrefs.SetFloat("BuffoAlquimistasHardness", buffoAlquimistasHardness);
        PlayerPrefs.SetFloat("BuffoAlquimistasRGB", buffoAlquimistasRGB);
        PlayerPrefs.SetFloat("TimeSpawnAldeanoPark", timeSpawnAldeanoPark);
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
        if (cantidadZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadZafiro))));
            var mantissa = (cantidadZafiro / System.Math.Pow(10, exponent));
            cantidadZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadZafiroText.text = cantidadZafiro.ToString("F0");

        }
        if (cantidadZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadZafiro))));
            var mantissa = (cantidadZafiro / System.Math.Pow(10, exponent));
            cantidadZafiroText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadZafiroText.text = cantidadZafiro.ToString("F0");

        }
        if (cantidadStarPoints >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadStarPoints))));
            var mantissa = (cantidadStarPoints / System.Math.Pow(10, exponent));
            cantidadStarPointsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadStarPointsText.text = cantidadStarPoints.ToString("F0");

        }
        if (cantidadReqParaStarPoint >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadReqParaStarPoint))));
            var mantissa = (cantidadReqParaStarPoint / System.Math.Pow(10, exponent));
            cantidadGoldReqParaStarPointsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadGoldReqParaStarPointsText.text = cantidadReqParaStarPoint.ToString("F0");

        }
        if (cantidadStarPointsAlPrestigear >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadStarPointsAlPrestigear))));
            var mantissa = (cantidadStarPointsAlPrestigear / System.Math.Pow(10, exponent));
            cantidadStarPointsAlPrestigearText.text = "+" + mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadStarPointsAlPrestigearText.text = "+" + cantidadStarPointsAlPrestigear.ToString("F0");

        }
        if (cantidadStarPointsGanadosPorGold >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadStarPointsGanadosPorGold))));
            var mantissa = (cantidadStarPointsGanadosPorGold / System.Math.Pow(10, exponent));
            cantidadStarPointsGanadosPorGoldText.text = "+" + mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            cantidadStarPointsGanadosPorGoldText.text = "+" + cantidadStarPointsGanadosPorGold.ToString("F0");

        }





    }
    void ActualizarStats()
    {
        Invoke(nameof(ActualizarStats), 2f);

        if (totalZafiro >= 1)
        {
            menuInfoTotalZafiroMostrar.SetActive(true);
        }
        if (totalStarPoints >= 1)
        {
            menuInfoTotalStarPointsMostrar.SetActive(true);
        }
        if (cantidadDworfsMineros >= 1)
        {
            menuInfoRangedMinersMostrar.SetActive(true);
        }
        if (cantidadDrills >= 1)
        {
            menuInfoPowerDrillsMostrar.SetActive(true);
        }
        if (cantidadDworfsAlquimistas >= 1)
        {
            menuInfoAlchemistMostrar.SetActive(true);
        }



        if (totalOro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(totalOro))));
            var mantissa = (totalOro / System.Math.Pow(10, exponent));
            oroTotalText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            oroTotalText.text = totalOro.ToString("F0");

        }
        if (totalFe >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(totalFe))));
            var mantissa = (totalFe / System.Math.Pow(10, exponent));
            feTotalText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            feTotalText.text = totalFe.ToString("F0");

        }
        if (totalZafiro >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(totalZafiro))));
            var mantissa = (totalZafiro / System.Math.Pow(10, exponent));
            zafiroTotalText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            zafiroTotalText.text = totalZafiro.ToString("F0");

        }
        if (totalStarPoints >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(totalStarPoints))));
            var mantissa = (totalStarPoints / System.Math.Pow(10, exponent));
            starPointsTotalText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            starPointsTotalText.text = totalStarPoints.ToString("F0");

        }
        if (totalClicks >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(totalClicks))));
            var mantissa = (totalClicks / System.Math.Pow(10, exponent));
            clicksTotalText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            clicksTotalText.text = totalClicks.ToString("F0");

        }
        if (dañoClick >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(dañoClick))));
            var mantissa = (dañoClick / System.Math.Pow(10, exponent));
            clickDamageText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            clickDamageText.text = dañoClick.ToString("F0");

        }

        critProbText.text = probCrit.ToString("F0") + "%";


        if (dañoCrit >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(dañoCrit))));
            var mantissa = (dañoCrit / System.Math.Pow(10, exponent));
            critDamageText.text = "x" + mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            critDamageText.text = "x" + dañoCrit.ToString("F1");

        }
        if (valorDworfsFe >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(valorDworfsFe))));
            var mantissa = (valorDworfsFe / System.Math.Pow(10, exponent));
            faithPerDworfText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            faithPerDworfText.text = valorDworfsFe.ToString("F1");

        }
        if (cantidadDworfsCollectors >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadDworfsCollectors))));
            var mantissa = (cantidadDworfsCollectors / System.Math.Pow(10, exponent));
            totalCollectorsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            totalCollectorsText.text = cantidadDworfsCollectors.ToString("F0");

        }
        if (cargoMaxCollectors >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cargoMaxCollectors))));
            var mantissa = (cargoMaxCollectors / System.Math.Pow(10, exponent));
            collectorsCapacityText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            collectorsCapacityText.text = cargoMaxCollectors.ToString("F0");

        }
        if (speedCollectorsRecolectar >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(speedCollectorsRecolectar))));
            var mantissa = (speedCollectorsRecolectar / System.Math.Pow(10, exponent));
            collectorsSpeedText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            collectorsSpeedText.text = speedCollectorsRecolectar.ToString("F1");

        }
        if (cantidadDworfsMineros >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadDworfsMineros))));
            var mantissa = (cantidadDworfsMineros / System.Math.Pow(10, exponent));
            totalRangedMinersText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            totalRangedMinersText.text = cantidadDworfsMineros.ToString("F0");

        }
        if (dañoDworfsMineros >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(dañoDworfsMineros))));
            var mantissa = (dañoDworfsMineros / System.Math.Pow(10, exponent));
            rangedMinersDamageText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            rangedMinersDamageText.text = dañoDworfsMineros.ToString("F0");

        }
        if (speedAtaqueMiners >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(speedAtaqueMiners))));
            var mantissa = (speedAtaqueMiners / System.Math.Pow(10, exponent));
            rangedMinersAttackSpeedText.text = mantissa.ToString("F2") + "e" + exponent + "s";

        }
        else
        {
            rangedMinersAttackSpeedText.text = speedAtaqueMiners.ToString("F1") + "s";

        }
        if (energiaMiners >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(energiaMiners))));
            var mantissa = (energiaMiners / System.Math.Pow(10, exponent));
            rangedMinersAwakeTimeText.text = mantissa.ToString("F2") + "e" + exponent + "s";

        }
        else
        {
            rangedMinersAwakeTimeText.text = energiaMiners.ToString("F1") + "s";

        }

        rangedMinersSleepTimeText.text = sleepMiners.ToString("F1") + "s";


        if (cantidadDrills >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadDrills))));
            var mantissa = (cantidadDrills / System.Math.Pow(10, exponent));
            totalPowerDrillsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            totalPowerDrillsText.text = cantidadDrills.ToString("F0");

        }
        if (dañoDrills >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(dañoDrills))));
            var mantissa = (dañoDrills / System.Math.Pow(10, exponent));
            powerDrillDamageText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            powerDrillDamageText.text = dañoDrills.ToString("F0");

        }
        if (speedAtaqueDrills >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(speedAtaqueDrills))));
            var mantissa = (speedAtaqueDrills / System.Math.Pow(10, exponent));
            powerDrillAttackSpeedText.text = mantissa.ToString("F2") + "e" + exponent + "s";

        }
        else
        {
            powerDrillAttackSpeedText.text = speedAtaqueDrills.ToString("F1") + "s";

        }
        if (energiaDrill >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(energiaDrill))));
            var mantissa = (energiaDrill / System.Math.Pow(10, exponent));
            powerDrillResistanceText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            powerDrillResistanceText.text = energiaDrill.ToString("F1");

        }
        if (cantidadDworfsAlquimistas >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(cantidadDworfsAlquimistas))));
            var mantissa = (cantidadDworfsAlquimistas / System.Math.Pow(10, exponent));
            totalAlchemistsText.text = mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            totalAlchemistsText.text = cantidadDworfsAlquimistas.ToString("F0");

        }
        if (buffoAlquimistasDworfs >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(buffoAlquimistasDworfs))));
            var mantissa = (buffoAlquimistasDworfs / System.Math.Pow(10, exponent));
            pocionDworfBuffText.text = "x" + mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            pocionDworfBuffText.text = "x" + buffoAlquimistasDworfs.ToString("F1");

        }
        if (buffoAlquimistasHardness >= 1000)
        {
            var exponent = (System.Math.Floor(System.Math.Log10(System.Math.Abs(buffoAlquimistasHardness))));
            var mantissa = (buffoAlquimistasHardness / System.Math.Pow(10, exponent));
            pocionHardnessBuffText.text = "x" + mantissa.ToString("F2") + "e" + exponent;

        }
        else
        {
            pocionHardnessBuffText.text = "x" + buffoAlquimistasHardness.ToString("F1");

        }


    }
    void Update()
    {
      
        if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = 7;
           
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            cantidadOro += 1000000000;
            cantidadFe += 10000;
            cantidadZafiro += 10000;
            cantidadDworfsSinEmpleo += 3;
            cantidadStarPoints += 10;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1;
        }


    }

}

