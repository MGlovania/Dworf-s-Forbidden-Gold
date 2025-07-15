using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform Targetwanderer;
  
    public float Sspeed;
    public Vector3 Pcamera;


    private Vector3 origin;
    private Vector3 difference;

    public bool drag = false;
    public GameObject player;
  
    private void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if (drag == false)
            {
                drag = true;
                origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

        }
        else
        {
            drag = false;
        }
        if (drag)
        {
           player.transform.position = origin - difference;
            Camera.main.transform.position = origin - difference;
        }
    }
   
   
    private void FixedUpdate()
    {

        if (Targetwanderer != null)
        {
            Vector3 Dposition = Targetwanderer.position + Pcamera;
            Vector3 Sposition = Vector3.Lerp(transform.position, Dposition, Sspeed * Time.deltaTime);

            transform.position = Sposition;
        }
     

    }
}
