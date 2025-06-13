using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbujas : MonoBehaviour
{
    public Sprite burbujaExclamacion;
    public Sprite burbujaPuntosSuspensivos;
    public Sprite burbujaZZZ;
    public GameObject target;
    void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        target = null;
    }
    void Update()
    {
        if (target != null)
        {
            transform.position = target.transform.position + Vector3.up / 2 + Vector3.right / 2;
        }
        
    }
}
