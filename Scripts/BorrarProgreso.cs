using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BorrarProgreso : MonoBehaviour
{

    public static int puntoBorrar;

    void Start()
    {
        if (puntoBorrar >= 1)
        {
            PlayerPrefs.DeleteAll();
         
        }
        Invoke(nameof(Start2), 0.1f);
       
    }
    void Start2()
    {
       
        puntoBorrar = 0;
    }


   

    public void Borrar()
    {
        PlayerPrefs.DeleteAll();
        puntoBorrar = 2;
        Invoke(nameof(Cargar), 0.5f);
        Invoke(nameof(Start), 0.1f);



    }
    void Update()
    {
        if (puntoBorrar >= 1)
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(0);
            puntoBorrar -= 1;
        }

    }
    public void Borrar2()
    {
        PlayerPrefs.DeleteAll();
        puntoBorrar = 2;
        Invoke(nameof(Cargar), 0.5f);


    }
    void Cargar()
    {
        SceneManager.LoadScene(0);

    }
}
