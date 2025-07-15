using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public int puntoIntro;
    public int puntoIntroPrimeraPepita;
    public int puntoTruckEnDepositoIntro;
    public int puntoTruckDeVueltaEnMinaIntro;
    public GameObject dwarfMineroIntro;
    public GameObject dwarfChoferIntro;
    public GameObject camionIntro;
    public Sprite camionIntroChofer;
    public Sprite camionIntroSinChofer;
    public GameObject sueloRomper;
    public GameObject sueloPoner;
    public GameObject prefabParticulasSueloRomper;
    public GameObject prefabBurbujas;
    public GameObject carga;
    public int moverIntro;
    public BoxCollider2D sueloIntroQuitar;
    public GameObject piedra;
    public Sprite piedraResplandecer;
    public Sprite piedraComun;
    public GameObject casaMinero;
    public GameObject choferEsperar;
    public GameObject canvasMain;
    public GameObject canvasWorldMain;
    public GameObject main;
    public GameObject casaQuitar;
    public GameObject depositoQuitar;
    public GameObject choferVerdaderoPoner;
    public GameObject recuadroTutorial1;
    public GameObject recuadroTutorial2;
    public GameObject recuadroTutorial3;
    public GameObject recuadroTutorialSuction;
    public int puntoComprarSuction;
    public GameObject recuadroTutorial4;

    public int puntoDemoPlayed;

    public GameObject botonStart;
    public GameObject botonOpciones;
    public GameObject fugaz;

    public GameObject opcionesQuitar;
    void Start()
    {
        
        puntoIntro = PlayerPrefs.GetInt("PuntoIntro");
        puntoIntroPrimeraPepita = PlayerPrefs.GetInt("PuntoIntroPrimeraPepita");
        puntoTruckEnDepositoIntro = PlayerPrefs.GetInt("PuntoTruckEnDepositoIntro");
        puntoTruckDeVueltaEnMinaIntro = PlayerPrefs.GetInt("PuntoTruckDeVueltaEnMinaIntro");
        puntoDemoPlayed = PlayerPrefs.GetInt("PuntoDemoPlayed");
        //if (puntoDemoPlayed >= 1)
        //{
        //    GetComponent<BorrarProgreso>().Borrar();
        //}
        if (puntoIntro <= 0)
        {
            canvasMain.SetActive(false);
            canvasWorldMain.SetActive(false);
            main.SetActive(false);
            sueloIntroQuitar.enabled = false;
            botonStart.SetActive(true);
            botonOpciones.SetActive(true);
        }
        else
        {
            puntoComprarSuction = 1;
            casaQuitar.SetActive(false);
            depositoQuitar.SetActive(false);
            choferVerdaderoPoner.SetActive(true);
            dwarfMineroIntro.SetActive(false);
            dwarfChoferIntro.SetActive(false);
            camionIntro.SetActive(false);
            sueloRomper.SetActive(false);
            sueloPoner.SetActive(true);
            sueloIntroQuitar.enabled = true;
            canvasMain.SetActive(true);
            canvasWorldMain.SetActive(true);
            main.SetActive(true);
            carga.SetActive(false);
         
        }

     
      
    }
    public void Empezar()
    {
        opcionesQuitar.SetActive(false);
        Invoke(nameof(DwarfExclamacionIntro), 2.5f);
        Invoke(nameof(Verif), 0.25f);
        Invoke(nameof(QuitarCarga), 1f);
        botonStart.SetActive(false);
        botonOpciones.SetActive(false);
        fugaz.SetActive(true);
    }
    void Verif()
    {

        if (puntoIntroPrimeraPepita == 1)
        {
            puntoIntroPrimeraPepita = 2;
            dwarfChoferIntro.transform.position = dwarfChoferIntro.transform.position + Vector3.left / 2;
            dwarfChoferIntro.GetComponent<Animator>().SetBool("Esperando", false);
            GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfChoferIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
            obj.GetComponent<Burbujas>().target = dwarfChoferIntro;
            obj.GetComponent<ReturnObj>().time = 3;
            obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaExclamacion;
            dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up / 1.5f, 2);
          //  dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up * 2, 100 * Time.deltaTime);
            piedra.GetComponent<SpriteRenderer>().sprite = piedraComun;
            Invoke(nameof(QuitarIntro), 2f);
        }
        else
        {
            Invoke(nameof(Verif), 0.25f);
        }
       
    }
    void QuitarIntro()
    {
        camionIntro.SetActive(false);
        choferVerdaderoPoner.SetActive(true);
        dwarfChoferIntro.SetActive(false);

    }
    void DwarfExclamacionIntro()
    {
        GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfMineroIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
        obj.GetComponent<Burbujas>().target = dwarfMineroIntro;
        obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaExclamacion;
        Invoke(nameof(IntroDwarfsSaltar), 3f);
    }
    void QuitarCarga()
    {

        carga.GetComponent<Animator>().SetBool("Carga", true);
    }
    void IntroDwarfsSaltar()
    {
        dwarfMineroIntro.transform.position = Vector3.MoveTowards(dwarfMineroIntro.transform.position, dwarfMineroIntro.transform.position + Vector3.up / 1.5f, 2);
       // dwarfMineroIntro.transform.position = Vector3.MoveTowards(dwarfMineroIntro.transform.position, dwarfMineroIntro.transform.position + Vector3.up * 2, 100 * Time.deltaTime);
        Invoke(nameof(IntroDwarfsSaltar2), 0.5f);
    }
    void IntroDwarfsSaltar2()
    {
        dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up / 1.5f, 2);
      //  dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up * 2, 100 * Time.deltaTime);
        Invoke(nameof(DwarfCamioneroIrHaciaCamionIntro), 0.5f);
    }
    void DwarfCamioneroIrHaciaCamionIntro()
    {
        moverIntro = 1;
        dwarfChoferIntro.GetComponent<Animator>().SetBool("Caminar", true);
        dwarfChoferIntro.GetComponent<SpriteRenderer>().flipX = true;
        Invoke(nameof(QuitarDwarfCamioneroIntro), 0.5f);
    }
    void QuitarDwarfCamioneroIntro()
    {
        moverIntro = 2;
        dwarfMineroIntro.GetComponent<Animator>().SetBool("Caminar", true);
        camionIntro.GetComponent<SpriteRenderer>().sprite = camionIntroChofer;
        dwarfChoferIntro.SetActive(false);
        Invoke(nameof(SueloCasiRotoIntro), 2.9f);
        camionIntro.GetComponent<Animator>().SetBool("Deposito", true);
    }
    void SueloCasiRotoIntro()
    {
        camionIntro.GetComponent<Animator>().SetBool("Deposito", false);
        dwarfMineroIntro.GetComponent<Animator>().SetBool("Caminar", false);
        moverIntro = 0;
        ObjectPool.SpawnObject(prefabParticulasSueloRomper, dwarfMineroIntro.transform.position + Vector3.left / 3f + Vector3.down / 2.5f, Quaternion.identity);
        Invoke(nameof(Exclamacion2Intro), 0.75f);
    }
    void Exclamacion2Intro()
    {
        GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfMineroIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
        obj.GetComponent<Burbujas>().target = dwarfMineroIntro;
        obj.GetComponent<ReturnObj>().time = 1.25f;
        obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaExclamacion;
        Invoke(nameof(VolverSafeIntro), 0.75f);
    }
    void VolverSafeIntro()
    {
        dwarfMineroIntro.GetComponent<Animator>().SetBool("Caminar", true);
        camionIntro.GetComponent<Animator>().SetBool("Deposito", true);
        dwarfMineroIntro.GetComponent<SpriteRenderer>().flipX = true;
        moverIntro = 3;
        Invoke(nameof(DestruirSueloIntro), 1f);
    }
    void DestruirSueloIntro()
    {
        camionIntro.GetComponent<Animator>().SetBool("Deposito", false);
        dwarfMineroIntro.GetComponent<Animator>().SetBool("Caminar", false);
        moverIntro = 0;
        dwarfMineroIntro.GetComponent<SpriteRenderer>().flipX = false;
        sueloRomper.SetActive(false);
        sueloIntroQuitar.enabled = true;
        sueloPoner.SetActive(true);
        ObjectPool.SpawnObject(prefabParticulasSueloRomper, dwarfMineroIntro.transform.position + Vector3.right * 1.9f + Vector3.down / 2f, Quaternion.identity);
        Invoke(nameof(ChoferSalirIntro), 1.75f);
    }
    void ChoferSalirIntro()
    {
        dwarfChoferIntro.SetActive(true);
        dwarfChoferIntro.transform.position = camionIntro.transform.position;
        camionIntro.GetComponent<SpriteRenderer>().sprite = camionIntroSinChofer;
        dwarfChoferIntro.GetComponent<SpriteRenderer>().flipX = false;
        Invoke(nameof(PuntosSuspensivosIntro), 1.5f);
    }
    void PuntosSuspensivosIntro()
    {
        GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfChoferIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
        obj.GetComponent<Burbujas>().target = dwarfChoferIntro;
        obj.GetComponent<ReturnObj>().time = 2.5f;
        obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaPuntosSuspensivos;
        Invoke(nameof(ZZZIntro), 2.5f);
    }
    void ZZZIntro()
    {
        GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfMineroIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
        obj.GetComponent<Burbujas>().target = dwarfMineroIntro;
        obj.GetComponent<ReturnObj>().time = 3;
        obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaZZZ;
        dwarfMineroIntro.GetComponent<SpriteRenderer>().flipX = true;
        Invoke(nameof(MineroIrse), 2f);
    }
    void MineroIrse()
    {
        dwarfMineroIntro.GetComponent<Animator>().SetBool("Caminar", true);
        moverIntro = 4;
        Invoke(nameof(ChoferVoltearseIntro), 3f);
    }
    void ChoferVoltearseIntro()
    {
        dwarfChoferIntro.GetComponent<SpriteRenderer>().flipX = true;
        Invoke(nameof(ChoferDesVoltearseIntro), 2f);
    }
    void ChoferDesVoltearseIntro()
    {
        dwarfMineroIntro.SetActive(false);
        dwarfChoferIntro.GetComponent<SpriteRenderer>().flipX = false;
        carga.GetComponent<Animator>().SetBool("FadeOut", true);
        Invoke(nameof(RecuadroIntro), 3f);    
        Invoke(nameof(ChoferEsperarIntro), 2.2f);
    }
    void ChoferEsperarIntro()
    {
        canvasMain.SetActive(true);
        canvasWorldMain.SetActive(true);
        main.SetActive(true);
        casaQuitar.SetActive(false);
        depositoQuitar.SetActive(false);
        dwarfChoferIntro.transform.position = choferEsperar.transform.position;
        dwarfChoferIntro.GetComponent<Animator>().SetBool("Esperando", true);
    }
    public void RecuadroIntro()
    {
        puntoDemoPlayed = 1;
        PlayerPrefs.SetInt("PuntoDemoPlayed", puntoDemoPlayed);
        recuadroTutorial1.SetActive(true);
        recuadroTutorial2.SetActive(false);
    }
    public void RecuadroIntro2()
    {
        GetComponent<Recursos>().cantidadDworfsSinEmpleo = 1;
        GetComponent<Recursos>().cantidadDworfsChofer = 1;
        GetComponent<Recursos>().cantidadTotalDworfs = 2;
        puntoIntro = 1;
        PlayerPrefs.SetInt("PuntoIntro", puntoIntro);
        recuadroTutorial1.SetActive(false);
        recuadroTutorial2.SetActive(true);
        recuadroTutorial3.SetActive(false);
    }
   public  void RecuadroIntro3()
    {
        recuadroTutorial2.SetActive(false);
        recuadroTutorial3.SetActive(true);
    }
    public void RecuadroIntroQuitar()
    {
        recuadroTutorial3.SetActive(false);
        Invoke(nameof(RecuadroIntroSuction), 10);
    }
    public void RecuadroIntroQuitarFinal()
    {
        recuadroTutorial4.SetActive(false);
    }
    public void RecuadroIntroSuction()
    {
        recuadroTutorialSuction.SetActive(true);
        puntoComprarSuction = 1;
    }
    void ResplandecerPiedraIntro()
    {
        if (puntoIntroPrimeraPepita <= 0)
        {
            Invoke(nameof(QuitarResplandecerPiedraIntro), 1f);
            piedra.GetComponent<SpriteRenderer>().sprite = piedraResplandecer;
        }
        else
        {
            dwarfChoferIntro.transform.position = dwarfChoferIntro.transform.position + Vector3.left / 2;
            dwarfChoferIntro.GetComponent<Animator>().SetBool("Esperando", false);
            GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfChoferIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
            obj.GetComponent<Burbujas>().target = dwarfChoferIntro;
            obj.GetComponent<ReturnObj>().time = 3;
            obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaExclamacion;
            dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up / 1.5f, 2);
            piedra.GetComponent<SpriteRenderer>().sprite = piedraComun;
        }       
      
    }
    void QuitarResplandecerPiedraIntro()
    {
        if (puntoIntroPrimeraPepita <= 0)
        {
            piedra.GetComponent<SpriteRenderer>().sprite = piedraComun;
            Invoke(nameof(ResplandecerPiedraIntro), 1f);
        }
        else
        {
            dwarfChoferIntro.transform.position = dwarfChoferIntro.transform.position + Vector3.left / 2;
            dwarfChoferIntro.GetComponent<Animator>().SetBool("Esperando", false);
            GameObject obj = ObjectPool.SpawnObject(prefabBurbujas, dwarfChoferIntro.transform.position + Vector3.up / 2f, Quaternion.identity);
            obj.GetComponent<Burbujas>().target = dwarfChoferIntro;
            obj.GetComponent<ReturnObj>().time = 3;
            obj.GetComponent<SpriteRenderer>().sprite = obj.GetComponent<Burbujas>().burbujaExclamacion;
            dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, dwarfChoferIntro.transform.position + Vector3.up / 1.5f, 2);
            piedra.GetComponent<SpriteRenderer>().sprite = piedraComun;
        }
    }
  
    void Update()
    {
        if (moverIntro == 1)
        {
            dwarfChoferIntro.transform.position = Vector3.MoveTowards(dwarfChoferIntro.transform.position, camionIntro.transform.position, 1.75f * Time.deltaTime);
        }
        if (moverIntro == 2)
        {
            camionIntro.transform.position = Vector3.MoveTowards(camionIntro.transform.position, camionIntro.transform.position + Vector3.right, 1.25f * Time.deltaTime);
            dwarfMineroIntro.transform.position = Vector3.MoveTowards(dwarfMineroIntro.transform.position, dwarfMineroIntro.transform.position + Vector3.right, 1.25f * Time.deltaTime);
        }
        if (moverIntro == 3)
        {
            camionIntro.transform.position = Vector3.MoveTowards(camionIntro.transform.position, camionIntro.transform.position + Vector3.left, 2f * Time.deltaTime);
            dwarfMineroIntro.transform.position = Vector3.MoveTowards(dwarfMineroIntro.transform.position, dwarfMineroIntro.transform.position + Vector3.left, 2 * Time.deltaTime);
        }
        if (moverIntro == 4)
        {
            dwarfMineroIntro.transform.position = Vector3.MoveTowards(dwarfMineroIntro.transform.position, casaMinero.transform.position, 2.2f * Time.deltaTime);
        }
    }
}
