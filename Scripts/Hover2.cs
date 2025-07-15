using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Hover2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject image;
    public GameObject imagenHover2;
    public GameObject image2;
    public int range;
    public bool esCementerio;

  
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (esCementerio)
        {
            range = Random.Range(0, 200);
            if (range == 0)
            {
                image2.SetActive(true);
            }
            else
            {
                image.SetActive(true);
            }
        }
        else
        {
            if (imagenHover2 != null)
            {
                imagenHover2.SetActive(true);
            }
            image.SetActive(true);
        }
  
        

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (imagenHover2 != null)
        {
            imagenHover2.SetActive(false);
        }
        image.SetActive(false);
        if (esCementerio)
        {
            image2.SetActive(false);
        }
    }
}
