using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapeado : MonoBehaviour
{

    public GameObject prefabFlor1;
    public GameObject prefabFlor2;
    public GameObject prefabFlor3;
    public Vector3 mover;
    public int range;
    public GameObject objetoColliderFloresDestruir;

    public GameObject prefabHada;
    void Start()
    {
        Invoke(nameof(QuitarCollider), 0.5f);
      //  Invoke(nameof(SpawnHada), Random.Range(1, 2));
        for (int i = 0; i < 30; i++)
        {
            range = Random.Range(0, 3);
            if (range == 0)
            {
                Instantiate(prefabFlor1, new Vector3(-52 + mover.x, -3.35f, 0), Quaternion.identity);
            }
            if (range == 1)
            {
                Instantiate(prefabFlor2, new Vector3(-52 + mover.x, -3.35f, 0), Quaternion.identity);
            }
            if (range == 2)
            {
                Instantiate(prefabFlor3, new Vector3(-52 + mover.x, -3.35f, 0), Quaternion.identity);
            }
            mover += new Vector3(Random.Range(1f, 2.5f), 0, 0);

        }
    }
    void SpawnHada()
    {
        Invoke(nameof(SpawnHada), Random.Range(1, 2));
        range = Random.Range(0, 2);
        if (range == 0)
        {
         GameObject obj = ObjectPool.SpawnObject(prefabHada, new Vector3(-60, 0.45f, 0), Quaternion.identity);
            obj.GetComponent<Hada>().moverDerecha = 1;
        }
        else
        {
            GameObject obj = ObjectPool.SpawnObject(prefabHada, new Vector3(20, 0.45f, 0), Quaternion.identity);
            obj.GetComponent<Hada>().moverIzquierda = 1;
        }
    }
    void QuitarCollider()
    {
        Destroy(objetoColliderFloresDestruir);
    }


}
