using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ReadStrings : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public TMP_Text text6;
    public TMP_Text text7;
    public TMP_Text text8;
    public TMP_Text text9;
    public TMP_Text text10;
    public TMP_Text text11;
    public TMP_Text text12;
    public TMP_Text text13;
    public TMP_Text text14;
    public TMP_Text text15;
    public TMP_Text text16;
    public TMP_Text text17;
    public TMP_Text text18;
    public TMP_Text text19;
    public TMP_Text text20;
    public TMP_Text text21;
    public TMP_Text text22;
    public TMP_Text text23;
    public TMP_Text text24;
    public TMP_Text text25;
    public TMP_Text text26;
    public TMP_Text text27;
    public TMP_Text text28;
    public TMP_Text text29;
    public TMP_Text text30;
    public TMP_Text text31;
    public TMP_Text text32;
    public TMP_Text text33;
    public TMP_Text text34;

    public TMP_Text prueba1;
    public TMP_Text prueba2;
    public TMP_Text prueba3;
    public TMP_Text prueba4;
    public TMP_Text prueba5;

    public TMP_Text cantidadText;
    public int cantidad;
    public GameObject recuadroCantidad;

    public int range;

    public GameObject recuadroGanador;
    public TMP_Text textoGanador;

    public GameObject recuadroGanador2;
    public TMP_Text textoGanador2;

    public GameObject lista1;
    public GameObject lista2;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse2))
        {
            if (recuadroCantidad.activeSelf == false)
            {
                recuadroCantidad.SetActive(true);
            }
           else if (recuadroCantidad.activeSelf == true)
            {
                recuadroCantidad.SetActive(false);
            }
        }
        cantidadText.text = cantidad.ToString("F0");
    }
  public  void QuitarRecuadroCantidad()
    {
        recuadroCantidad.SetActive(false);
    }
    public void Añadir()
    {
        cantidad += 1;
    }
    public void Disminuir()
    {
        cantidad -= 1;
    }
    public void Lista1()
    {
        lista1.SetActive(true);
        lista2.SetActive(false);
    }
    public void Lista2()
    {
        lista1.SetActive(false);
        lista2.SetActive(true);
    }
    public void QuitarGanador1()
    {
        recuadroGanador.SetActive(false);
    }
    public void QuitarGanador2()
    {
        recuadroGanador2.SetActive(false);
    }
    public void Suspensivos1()
    {
        textoGanador.text = ".".ToString();
        recuadroGanador.SetActive(true);
        Invoke(nameof(Suspensivos2), 0.75f);
 

    }
    public void Suspensivos2()
    {
        textoGanador.text = "..".ToString();
        Invoke(nameof(Suspensivos3), 0.75f);
  

    }
    public void Suspensivos3()
    {
        textoGanador.text = "...".ToString();
        Invoke(nameof(Ganador), 0.75f);


    }
    public void Ganador()
    {

        range = Random.Range(0, cantidad);

        if (range == 0)
        {
            textoGanador.text = "¡" + text.text + "!";
        }
        else if (range == 1)
        {
            textoGanador.text = "¡" + text2.text + "!";
        }
        else if (range == 2)
        {
            textoGanador.text = "¡" + text3.text + "!";
        }

    }
    public void Suspensivos4()
    {
        textoGanador2.text = ".".ToString();
        recuadroGanador2.SetActive(true);
        Invoke(nameof(Suspensivos5), 0.75f);


    }
    public void Suspensivos5()
    {
        textoGanador2.text = "..".ToString();
        Invoke(nameof(Suspensivos6), 0.75f);


    }
    public void Suspensivos6()
    {
        textoGanador2.text = "...".ToString();
        Invoke(nameof(Ganador2), 0.75f);


    }
    public void Ganador2()
    {

        range = Random.Range(0, 5);

        if (range == 0)
        {
            textoGanador2.text = "¡" + prueba1.text + "!";
        }
        else if (range == 1)
        {
            textoGanador2.text = "¡" + prueba2.text + "!";
        }
        else if (range == 2)
        {
            textoGanador2.text = "¡" + prueba3.text + "!";
        }
        else if (range == 3)
        {
            textoGanador2.text = "¡" + prueba4.text + "!";
        }
        else if (range == 4)
        {
            textoGanador2.text = "¡" + prueba5.text + "!";
        }

    }
}
