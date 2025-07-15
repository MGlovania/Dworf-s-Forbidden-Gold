using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public double health;
    public double maxHealth;

    public Slider vidaSlider;

    void Start()
    {
        health = maxHealth;

      
    }

    void Update()
    {
        
    }
}
