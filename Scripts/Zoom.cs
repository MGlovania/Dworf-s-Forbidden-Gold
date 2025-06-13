using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoom;
    public float zoomMultiplier = 4f;
    public float minZoom = 1f;
    public float maxZoom = 55f;
    public float velocity = 0;
    public float smoothTime = 0.25f;

    [SerializeField] private Camera cam;

    public int noEstaEnPestigio;

    void Start()
    {
        zoom = cam.orthographicSize;   
    }

  
    void Update()
    {
        if (noEstaEnPestigio <= 0)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            zoom -= scroll * zoomMultiplier;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);

        }

    }
}
