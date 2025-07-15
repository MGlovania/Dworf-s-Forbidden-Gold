using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Zafiro : MonoBehaviour
{
    public GameObject prefabParticulas;
    public GameObject prefabPepita;
    public GameObject target;
    public GameObject manager;

    public double vida;
    public double vidaMax;

    public GameObject prefabPopUp;

    public Slider vidaSlider;
    public int range;

    public TMP_Text cantidadVidaActualText;
    void Start()
    {

        vidaMax = manager.GetComponent<Recursos>().vidaMaxZafiro;
        vida = vidaMax;

        vidaSlider.maxValue = (float)vidaMax;
        vidaSlider.value = (float)vidaMax;
        Invoke(nameof(Verif), 0.25f);
    }
    void Verif()
    {
        Invoke(nameof(Verif), 0.25f);
        cantidadVidaActualText.text = vida.ToString("F1");
        vidaSlider.maxValue = (float)vidaMax;
    }

    public void DañoDrill()
    {
        GameObject popUp = ObjectPool.SpawnObject(prefabPopUp, transform.position + new Vector3(Random.Range(-0.4f, 0.65f), Random.Range(0.75f, 1.1f), 0), Quaternion.identity);
        popUp.GetComponentInChildren<TMP_Text>().text = "-" + (manager.GetComponent<Recursos>().dañoDrills * ((float)1 + (0.25f *  manager.GetComponent<MejorasDrills>().nivelZafiroMasDañoAZafiro))).ToString("F0");
        vida -= (manager.GetComponent<Recursos>().dañoDrills * ((float)1 + (0.25f * manager.GetComponent<MejorasDrills>().nivelZafiroMasDañoAZafiro)));
        if (vida <= 0)
        {
            GetComponent<Animator>().SetBool("Click", true);
            Invoke(nameof(QuitarAnim), 0.1f);
            Vector2 direction = (target.transform.position + Vector3.up * Random.Range(7f, 7.5f)) - transform.position;
            transform.right = direction;
            GameObject obj = ObjectPool.SpawnObject(prefabPepita, transform.position + Vector3.up / 2f, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(6, 6.5f);
            transform.rotation = Quaternion.Euler(Vector3.zero);
            ObjectPool.SpawnObject(prefabParticulas, transform.position, Quaternion.identity);
            vida = vidaMax;
        }
    }
    void QuitarAnim()
    {
        GetComponent<Animator>().SetBool("Click", false);
    }
}
