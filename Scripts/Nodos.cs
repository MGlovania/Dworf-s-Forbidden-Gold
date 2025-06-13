using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodos : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineController line;

    [SerializeField] private Transform[] points2;
    [SerializeField] private LineController line2;
    void Start()
    {
        line.SetUpLine(points);
        line2.SetUpLine(points2);
    }

 
    void Update()
    {
        
    }
}
