using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObjetoLoopWithPool : MonoBehaviour
{
    [SerializeField] private GameObject objetoPrefab;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoEspera;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoIntervalo;

    private ObjectPool objectPool;


    private void Awake()
    {
        objectPool = GetComponent<ObjectPool>();
    }


    void Start()
    {
        InvokeRepeating(nameof(GenerarObjectLoop), tiempoEspera, tiempoIntervalo);
    }

    void GenerarObjectLoop()
    {
        GameObject pooledObject = objectPool.GetPooledObject();

        if (pooledObject != null)
        {
            pooledObject.transform.position = transform.position;
            pooledObject.transform.rotation = Quaternion.identity;
            pooledObject.SetActive(true);
        }
    }
    private void OnBecameInvisible()
    {
        Debug.Log("El SpriteRenderer deja de ser visible por las cámaras en la escena");
        CancelInvoke(nameof(GenerarObjectLoop));
    }
    private void OnBecameVisible()
    {
        Debug.Log("El SpriteRenderer es visible por las cámaras en la escena");
        InvokeRepeating(nameof(GenerarObjectLoop), tiempoEspera, tiempoIntervalo);
    }

}
