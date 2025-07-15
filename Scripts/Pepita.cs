using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepita : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public int puntoCargo;
    public bool puntoQuitarDrag;
    public int puntoMorir;
    public GameObject manager;
    public bool pepitaEspecialSuccionada;
    public bool pepitaColisionConSuelo;
    public bool esBase;
    public int cantidadStack;
    public SpriteRenderer sp;
    public Sprite nivel1;
    public Sprite nivel2;
    public Sprite nivel3;
    public Sprite nivel4;
    public Sprite nivel5;
    public Sprite nivel6;
    public Sprite nivel7;
    public Sprite nivel8;
    public Sprite nivel9;
    public Sprite nivel10;
    public Sprite nivel11;
    public Sprite nivel12;
    public Sprite nivel13;
    public Sprite nivel14;
    public Sprite nivel15;
    public Sprite nivel16;
    public Sprite nivel17;
    public Sprite nivel18;
    public Sprite nivel19;
    public Sprite nivel20;
    public Sprite nivel21;
    public Sprite nivel22;
    public Sprite nivel23;
    public Sprite nivel24;
    public Sprite nivel25;
    public Sprite nivel26;
    public Sprite nivel27;
    public Sprite nivel28;
    public Sprite nivel29;
    public Sprite nivel30;
    public BoxCollider2D bx;
    public GameObject player;
    void OnEnable()
    {
        esBase = false;

        puntoCargo = 0;
        manager = GameObject.FindGameObjectWithTag("Manager");
        player = GameObject.FindGameObjectWithTag("Player");

        puntoMorir = 0;
        Invoke(nameof(Verif), 0.25f);
      //  Invoke(nameof(Ret), 2.5f);
        pepitaEspecialSuccionada = false;
        pepitaColisionConSuelo = false;
        sp = GetComponent<SpriteRenderer>();
        cantidadStack = 0;
     
        sp.sprite = nivel1;
   
    }
    void Ret()
    {
        if (puntoMorir == 2 && !esBase && !pepitaColisionConSuelo)
        {
            manager.GetComponent<Recursos>().pepitaGuardadaParaAumentarEnOtroStack += 1;
            ObjectPool.ReturnObjectToPool(gameObject);
        }
    }
    void QuitarPorPrestigio()
    {
        ObjectPool.ReturnObjectToPool(gameObject);
    }
    void Verif()
    {
        if (player.GetComponent<PJ>().puntoPrestigio >= 1)
        {
            Invoke(nameof(QuitarPorPrestigio), 0.5f);
        }
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Verif), 0.25f);
            if (!esBase && bx.enabled == true)
            {
                bx.enabled = false;
            }
           else if (!esBase && bx.enabled == false)
            {
                bx.enabled = true;
            }
        }
        if (cantidadStack == 0)
        {
            sp.sprite = nivel1;

        }
        else if (cantidadStack == 1)
        {
            sp.sprite = nivel2;
         
        }
       else if (cantidadStack == 2)
        {
            sp.sprite = nivel2;
        
        }
        else if (cantidadStack == 3)
        {
            sp.sprite = nivel3;
          
        }
        else if (cantidadStack == 4)
        {
            sp.sprite = nivel4;
         
        }
        else if (cantidadStack == 5)
        {
            sp.sprite = nivel5;
          
        }
        else if (cantidadStack == 6)
        {
            sp.sprite = nivel6;
         
        }
        else if (cantidadStack == 7)
        {
            sp.sprite = nivel7;
         
        }
        else if (cantidadStack == 8)
        {
            sp.sprite = nivel8;
  
        }
        else if (cantidadStack == 9)
        {
            sp.sprite = nivel9;
        }
        else if (cantidadStack == 10)
        {
            sp.sprite = nivel10;
        }
        else if (cantidadStack == 11)
        {
            sp.sprite = nivel11;
        }
        else if (cantidadStack == 12)
        {
            sp.sprite = nivel12;
        }
        else if (cantidadStack == 13)
        {
            sp.sprite = nivel13;
        }
        else if (cantidadStack == 14)
        {
            sp.sprite = nivel14;
        }
        else if (cantidadStack == 15)
        {
            sp.sprite = nivel15;
        }
        else if (cantidadStack == 16)
        {
            sp.sprite = nivel16;
        }
        else if (cantidadStack == 17)
        {
            sp.sprite = nivel17;
        }
        else if (cantidadStack == 18)
        {
            sp.sprite = nivel18;
        }
        else if (cantidadStack == 19)
        {
            sp.sprite = nivel19;
        }
        else if (cantidadStack == 20)
        {
            sp.sprite = nivel20;
        }
        else if (cantidadStack == 21)
        {
            sp.sprite = nivel21;
        }
        else if (cantidadStack == 22)
        {
            sp.sprite = nivel22;
        }
        else if (cantidadStack == 23)
        {
            sp.sprite = nivel23;
        }
        else if (cantidadStack == 24)
        {
            sp.sprite = nivel24;
        }
        else if (cantidadStack == 25)
        {
            sp.sprite = nivel25;
        }
        else if (cantidadStack == 26)
        {
            sp.sprite = nivel26;
        }
        else if (cantidadStack == 27)
        {
            sp.sprite = nivel27;
        }
        else if (cantidadStack == 28)
        {
            sp.sprite = nivel28;
        }
        else if (cantidadStack == 29)
        {
            sp.sprite = nivel29;
        }
        else if (cantidadStack == 30)
        {
            sp.sprite = nivel30;
        }
        if (manager.GetComponent<Recursos>().pepitaGuardadaParaAumentarEnOtroStack >= 1 && cantidadStack < 30 && esBase)
        {
            cantidadStack += 1;
            manager.GetComponent<Recursos>().pepitaGuardadaParaAumentarEnOtroStack -= 1;
        }
        if (manager.GetComponent<Recursos>().puntoSuccion == 1 && esBase)
        {
            manager.GetComponent<Recursos>().cantidadPepitasActual -= manager.GetComponent<Recursos>().pesoPiedra;
            cantidadStack -= 1;
            manager.GetComponent<Recursos>().puntoSuccion = 0;
            if (cantidadStack <= -1)
            {
                puntoMorir = 2;
                ObjectPool.ReturnObjectToPool(gameObject);
            }
           
         
        }
    }
  
    //private void OnMouseDrag()
    //{
    //    if (!pepitaEspecialSuccionada)
    //    {
    //        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        puntoQuitarDrag = true;
    //    }                  

    //}
  
    //private void OnMouseUp()
    //{
    //    puntoQuitarDrag = false;
    //}
    private void OnDisable()
    {
        if (puntoMorir != 2 && manager != null)
        {
            manager.GetComponent<Recursos>().cantidadPepitasActual -= manager.GetComponent<Recursos>().pesoPiedra;
        }
    
        puntoMorir = 1;
           cantidadStack = 0;
        sp.sprite = nivel1;
        esBase = false;
        if (pepitaColisionConSuelo)
        {
            manager.GetComponent<Recursos>().cantidadPepitasEnSuelo -= 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("Suelo"))
        {
            if (manager.GetComponent<Recursos>().puntoColliderSonidoPiedra >= 1)
            {
                AudioManager.instance.PlaySFX("PlopPepita");
            }
            esBase = true;
            if (!pepitaColisionConSuelo)
            {

                pepitaColisionConSuelo = true;
                manager.GetComponent<Recursos>().cantidadPepitasEnSuelo += 1;
            }
          
        }
        if (collision.CompareTag("DestruirPepitas") && puntoMorir <= 0)
        {
            manager.GetComponent<Recursos>().cantidadPepitasActual -= manager.GetComponent<Recursos>().pesoPiedra;
            puntoMorir = 1;
            ObjectPool.ReturnObjectToPool(gameObject);
        }
        if (collision.CompareTag("Pepita") && !esBase && puntoMorir <= 0)
        {
            if (manager.GetComponent<Recursos>().puntoColliderSonidoPiedra >= 1)
            {
                AudioManager.instance.PlaySFX("PlopPepita");
            }
            if (collision.GetComponent<Pepita>().esBase && collision.GetComponent<Pepita>().cantidadStack < 30)
            {
                puntoMorir = 2;
                collision.GetComponent<Pepita>().cantidadStack += 1;
                ObjectPool.ReturnObjectToPool(gameObject);
            }
            else if (collision.GetComponent<Pepita>().esBase && collision.GetComponent<Pepita>().cantidadStack >= 30)
            {
                puntoMorir = 2;
                manager.GetComponent<Recursos>().pepitaGuardadaParaAumentarEnOtroStack += 1;
                ObjectPool.ReturnObjectToPool(gameObject);
            }
          
        }

    }
   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            if (pepitaColisionConSuelo)
            {
                pepitaColisionConSuelo = false;
                manager.GetComponent<Recursos>().cantidadPepitasEnSuelo -= 1;
            }
            if (esBase)
            {
                esBase = false;
           
            }

        }
      
    }

}
