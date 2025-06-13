using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observatorio : MonoBehaviour
{

    public GameObject recuadroPrestigio;
    public int puntoRecuadroPrestigio;
    void Start()
    {
     
    }
    public void RecuadroPrestigio()
    {
        if (puntoRecuadroPrestigio <= 0)
        {
            puntoRecuadroPrestigio = 1;
            recuadroPrestigio.SetActive(true);
        }
        else 
        {
            puntoRecuadroPrestigio = 0;
            recuadroPrestigio.SetActive(false);
        }
    }

   
  
    void Update()
    {
        
    }
}
