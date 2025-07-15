using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoArtificial : MonoBehaviour
{
    public GameObject prefabParticulasHumo;
    public GameObject prefabParticulaFuegoArtificial;
    public GameObject prefabParticulaFuegoArtificial2;
    public GameObject prefabParticulaFuegoArtificial3;
    public int puntoFuegoArtificial1;
    public int puntoFuegoArtificial2;
    public int puntoFuegoArtificial3;
    public int puntoMorir;
    public int range;

    public Rigidbody2D rb;

    
    void OnEnable()
    {
        range = Random.Range(0, 2);
        if (range == 0)
        {
            AudioManager.instance.PlaySFX("FuegoArtificialMecha");
        }
        else
        {
            AudioManager.instance.PlaySFX("FuegoArtificialMecha2");
        }
        puntoMorir = 0;
        Invoke(nameof(Explotar), Random.Range(1.4f,1.8f));
        Invoke(nameof(Humo), 0.2f);
    }
    void Humo()
    {
        if (puntoMorir <= 0)
        {
            Invoke(nameof(Humo), 0.2f);
            ObjectPool.SpawnObject(prefabParticulasHumo, transform.position, Quaternion.identity);
        }
     
    }
    void Explotar()
    {
        range = Random.Range(0, 2);
        if (range == 0)
        {
          AudioManager.instance.PlaySFX("FuegoArtificialExplotar");
        }
        else
        {
            AudioManager.instance.PlaySFX("FuegoArtificialExplotar2");
        }
        puntoMorir = 1;
        if (puntoFuegoArtificial1 == 1)
        {     
            ObjectPool.SpawnObject(prefabParticulaFuegoArtificial, transform.position, Quaternion.identity);
        }
        else if (puntoFuegoArtificial2 == 1)
        {        
            ObjectPool.SpawnObject(prefabParticulaFuegoArtificial2, transform.position, Quaternion.identity);
        }
        else
        {
            ObjectPool.SpawnObject(prefabParticulaFuegoArtificial3, transform.position, Quaternion.identity);
        }
   
      
        ObjectPool.ReturnObjectToPool(gameObject);

    }
   
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.up, 3 * Time.deltaTime);
     
    }
}
