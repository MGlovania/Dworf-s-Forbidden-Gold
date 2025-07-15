using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnObj : MonoBehaviour
{
    public float time;
    public bool esPepitaProp;
    public double cantidadPepita;
    public int puntoMorir;

    public bool esMinerMoverDerecha;
    public bool esMinerQuieto;
    public bool esMineroVolver;
    public GameObject mineroQuieto;
    public GameObject mineroMoverIzquierda;
    public GameObject mineroSaltar;
    public GameObject manager;
    public Sprite nada;
    public Sprite mineroQuietoSp;

    public int puntoDesactivar;

    public bool esDrill;
    public bool esDrillZafiro;
    public GameObject particulasDrillHumo;
    public GameObject particulasDrillAtacar;
    public GameObject piedra;
    public GameObject piedraZafiro;

    public GameObject player;
    public GameObject particulasQuitar;

    public bool esAlquimista;
    public int puntoMoverAlquimistas;
    public int puntoMoverHaciaRoca;
    public int puntoMoverHaciaCentro;
    public int puntoMoverHaciaZafiro;
    public GameObject particulasPocionDworf;
    public GameObject particulasPocionHardness;
    public GameObject particulasPocionRGB;
    public Vector3 posicionAlquimista;
    public Sprite alquimistaNada;
    public Sprite alquimistaQuieto;

    public int puntoSonido;
    public int puntoSonidoZafiroYTal;

    public int range;

    void OnEnable()
    {
        puntoMoverAlquimistas = 1;
        manager = GameObject.FindGameObjectWithTag("Manager");
        piedra = GameObject.FindGameObjectWithTag("Piedra");
        piedraZafiro = GameObject.FindGameObjectWithTag("PiedraZafiro");
        player = GameObject.FindGameObjectWithTag("Player");
        puntoMorir = 0;
        if (!esPepitaProp)
        {
            Invoke(nameof(Verif), 0.1f);
        }
        else
        {
            Invoke(nameof(Verif), 0.1f);
        }
        if (esPepitaProp)
        {
            Invoke(nameof(QuitarPepita), 0.7f);
        }
        if (esMinerQuieto)
        {
            Invoke(nameof(MineroSaltar), 0f);
        }
        if (esDrill)
        {
            Invoke(nameof(Bajar), 10.8f);
            Invoke(nameof(ParticulaDrill), 0.4f);
            Invoke(nameof(VerifSonido), 2);
        }
        if (esAlquimista)
        {
            Invoke(nameof(VerifMoverAlquimistas), 2f);
        }
        Invoke(nameof(VerifUpdate), 0.25f);
    }
    void QuitarPepita()
    {
        if (puntoMorir <= 0)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }

    }
    void VerifSonido()
    {
        if (manager.GetComponent<Recursos>().puntoColliderSonidoPiedra >= 1)
        {
            puntoSonido = 1;
        }
        else
        {
            puntoSonido = 0;
        }
    }
    void QuitarMovAlquimista()
    {
        if (puntoMoverAlquimistas >= 1)
        {
            GetComponent<Animator>().SetBool("Mov", false);
            GetComponent<Animator>().SetBool("Quieto", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Mov", false);
            GetComponent<Animator>().SetBool("Quieto", true);
            if (puntoMoverHaciaCentro >= 1)
            {
                Invoke(nameof(AtacarAlquimistaDworf), 1f);
            }
            else if (puntoMoverHaciaZafiro >= 1)
            {
                Invoke(nameof(AtacarAlquimistaRGB), 1f);
            }
            else if (puntoMoverHaciaRoca >= 1)
            {
                Invoke(nameof(AtacarAlquimistaHardness), 1f);
            }

        }
        puntoMoverAlquimistas = 0;
        puntoMoverHaciaCentro = 0;
        puntoMoverHaciaRoca = 0;
        puntoMoverHaciaZafiro = 0;
        Invoke(nameof(VerifMoverAlquimistas), 3f);
    }
    void VerifMoverAlquimistas()
    {


        if (manager.GetComponent<Menus>().puntoDworfSeleccionada >= 1)
        {
            Invoke(nameof(QuitarMovAlquimista), 5f);
            puntoMoverAlquimistas = 0;
            puntoMoverHaciaCentro = 1;
            GetComponent<Animator>().SetBool("Mov", true);
            GetComponent<Animator>().SetBool("Quieto", false);
            GetComponent<SpriteRenderer>().sprite = alquimistaQuieto;

            posicionAlquimista = new Vector3(Random.Range(-16.8f, -8.25f), transform.position.y, 0);
        }
        else if (manager.GetComponent<Menus>().puntoHardnessSeleccionada >= 1)
        {
            Invoke(nameof(QuitarMovAlquimista), 6f);
            puntoMoverAlquimistas = 0;
            puntoMoverHaciaRoca = 1;
            GetComponent<Animator>().SetBool("Mov", true);
            GetComponent<Animator>().SetBool("Quieto", false);
            GetComponent<SpriteRenderer>().sprite = alquimistaQuieto;
            posicionAlquimista = new Vector3(Random.Range(1.85f, 1.55f), transform.position.y, 0);
        }
        else if (manager.GetComponent<Menus>().puntoRGBSeleccionada >= 1)
        {
            Invoke(nameof(QuitarMovAlquimista), 5f);
            puntoMoverAlquimistas = 0;
            puntoMoverHaciaZafiro = 1;
            GetComponent<Animator>().SetBool("Mov", true);
            GetComponent<Animator>().SetBool("Quieto", false);
            GetComponent<SpriteRenderer>().sprite = alquimistaQuieto;
            posicionAlquimista = new Vector3(Random.Range(-5.5f, -2.5f), transform.position.y, 0);
        }
        else
        {
            Invoke(nameof(QuitarMovAlquimista), 6f);
            puntoMoverAlquimistas = 1;
            GetComponent<Animator>().SetBool("Mov", false);
            GetComponent<Animator>().SetBool("Quieto", false);
            GetComponent<SpriteRenderer>().sprite = alquimistaNada;
            posicionAlquimista = new Vector3(Random.Range(-16.8f, -8.25f), transform.position.y, 0);
        }


    }
    void AtacarAlquimistaDworf()
    {
        ObjectPool.SpawnObject(particulasPocionDworf, transform.position, Quaternion.identity);
    }
    void AtacarAlquimistaHardness()
    {
        ObjectPool.SpawnObject(particulasPocionHardness, transform.position, Quaternion.Euler(new Vector3(0, 0, -21.4f)));
    }
    void AtacarAlquimistaRGB()
    {
        ObjectPool.SpawnObject(particulasPocionRGB, transform.position, Quaternion.identity);
    }
    void ParticulaDrill()
    {

        if (GetComponent<Animator>().GetBool("Atacar") != true && puntoMorir <= 0)
        {
            ObjectPool.SpawnObject(particulasDrillHumo, transform.position, Quaternion.identity);
            Invoke(nameof(ParticulaDrill), Random.Range(0.25f, 0.4f));
        }
        else if (puntoMorir <= 0)
        {
            Invoke(nameof(ParticulaDrillAtacar), 1.25f);
        }
       
    }
    void ParticulaDrillAtacar()
    {
        if (puntoMorir <= 0)
        {
            ObjectPool.SpawnObject(particulasDrillAtacar, transform.position, Quaternion.identity);
            Invoke(nameof(ParticulaDrill), 0.75f);
        }

    }
    void Bajar()
    {
        GetComponent<Animator>().SetBool("Subir", false);
        GetComponent<Animator>().SetBool("Atacar", true);
        Invoke(nameof(AtacarDrill), 1.25f);
        Invoke(nameof(Sobrecalentar), manager.GetComponent<Recursos>().energiaDrill);
        Invoke(nameof(Mover), 2);
    }
    void AtacarDrill()
    {
        if (GetComponent<Animator>().GetBool("Atacar") == true && puntoMorir <= 0 || GetComponent<Animator>().GetBool("Sobrecalentar") == true && puntoMorir <= 0)
        {
            if (esDrillZafiro)
            {
                piedraZafiro.GetComponent<Zafiro>().DañoDrill();
            }
            else
            {
                piedra.GetComponent<Piedra>().DañoDrill();
            }

            Invoke(nameof(AtacarDrill), 0.5f);
            if (puntoSonido >= 1)
            {
                AudioManager.instance.PlaySFX("DrillDaño");
            }
          
        }

    }
  
    void Mover()
    {
        transform.position = new Vector3(transform.position.x + Random.Range(-5.5f, 5.5f), transform.position.y, 0);
    }
    void Sobrecalentar()
    {
        GetComponent<Animator>().SetBool("Atacar", false);
        GetComponent<Animator>().SetBool("Sobrecalentar", true);
        Invoke(nameof(Subir), 3);
    }
    void Subir()
    {
        GetComponent<Animator>().SetBool("Sobrecalentar", false);
        GetComponent<Animator>().SetBool("Subir", true);
        Invoke(nameof(PermanecerQuietoDrill), 8);

    }
    void PermanecerQuietoDrill()
    {
        GetComponent<Animator>().SetBool("Subir", false);
        Invoke(nameof(Bajar), 5);
    }
    void MineroSaltar()
    {
        if (puntoMorir <= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up / 1.5f, 2);
            Invoke(nameof(MineroSaltar), manager.GetComponent<Recursos>().speedAtaqueMiners);
            //GetComponent<SpriteRenderer>().sprite = nada;
            //Invoke(nameof(RetomarSprite), 0.1f);
            //ObjectPool.SpawnObject(mineroSaltar, transform.position, Quaternion.identity);
        }
    
    
    }
    void RetomarSprite()
    {
        GetComponent<SpriteRenderer>().sprite = mineroQuietoSp;
    }
    void VerifUpdate()
    {
        if (esAlquimista)
        {
            if (transform.position.x >= posicionAlquimista.x)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (transform.position.x <= posicionAlquimista.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            if (transform.position == posicionAlquimista)
            {
                GetComponent<Animator>().SetBool("Mov", false);
                GetComponent<Animator>().SetBool("Quieto", true);
            }
        }

        if (puntoMorir <= 0)
        {
            Invoke(nameof(VerifUpdate), 0.25f);
            if (player.GetComponent<PJ>().puntoPrestigio >= 1)
            {
                ObjectPool.SpawnObject(particulasQuitar, transform.position, Quaternion.identity);
                ObjectPool.ReturnObjectToPool(gameObject);
            }
        }
        if (esDrill && manager.GetComponent<Recursos>().puntoDestruirDrill >= 1)
        {
            ObjectPool.ReturnObjectToPool(gameObject);
        }
      
    }
    void Verif()
    {
       
        if (!esPepitaProp && puntoMorir <= 0)
        {
            Invoke(nameof(Quitar), time);
        }
    }
    private void FixedUpdate()
    {
    
        if (puntoMoverAlquimistas >= 1 && esAlquimista && posicionAlquimista != new Vector3(0,0,0))
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAlquimista, 3.5f * Time.deltaTime);
        }
       else if (puntoMoverHaciaCentro >= 1 && esAlquimista)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAlquimista, 2.5f * Time.deltaTime);
        }
        else if (puntoMoverHaciaZafiro >= 1 && esAlquimista)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAlquimista, 3f * Time.deltaTime);
        }

        else if (puntoMoverHaciaRoca >= 1 && esAlquimista)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicionAlquimista, 3.5f * Time.deltaTime);
        }
     
    }
    private void OnApplicationQuit()
    {
        puntoDesactivar = 1;
    }
    void Quitar()
    {
        if (!esPepitaProp && !esDrill && !esAlquimista && puntoMorir <= 0)
        {
            if (esMinerMoverDerecha && puntoDesactivar <= 0)
            {
                GameObject obj = ObjectPool.SpawnObject(mineroQuieto, new Vector3(Random.Range(2.75f, 3), -3.15f, 0), Quaternion.identity);
                obj.GetComponent<ReturnObj>().time = manager.GetComponent<Recursos>().energiaMiners;
            }
            if (esMinerQuieto && puntoDesactivar <= 0)
            {
                GameObject obj = ObjectPool.SpawnObject(mineroMoverIzquierda, transform.position, Quaternion.identity);
                obj.GetComponent<Animator>().speed = manager.GetComponent<Recursos>().speedMiners;
                obj.GetComponent<ReturnObj>().time = 7 / manager.GetComponent<Recursos>().speedMiners;
                manager.GetComponent<Recursos>().cantidadDworfsMinerosEnPantalla -= 1;
                manager.GetComponent<Recursos>().cantidadDworfsDurmiendo += 1;
            }
            ObjectPool.ReturnObjectToPool(gameObject);
        }    
    }
  
   
    private void OnDisable()
    {
        puntoMoverAlquimistas = 0;
        if (esMineroVolver && player.GetComponent<PJ>().puntoPrestigio <= 0)
        {
            manager.GetComponent<Recursos>().MineroSleep();
        }
        puntoMorir = 1;
           cantidadPepita = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (esPepitaProp && collision.CompareTag("Dworf") && puntoMorir <= 0)
        //{           
        //    puntoMorir = 1;
        //    collision.GetComponent<Dworfs>().cargoActual += cantidadPepita;
        //    ObjectPool.ReturnObjectToPool(gameObject);
        //}
    }
}
