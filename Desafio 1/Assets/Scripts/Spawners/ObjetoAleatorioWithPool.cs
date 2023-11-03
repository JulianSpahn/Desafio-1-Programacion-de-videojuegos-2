using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAleatorioWithPool : MonoBehaviour
{
    [SerializeField] private GameObject[] objetosPrefabs;
    [SerializeField] private int Aleatorios;

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
        InvokeRepeating(nameof(GenerarObjectAleatorio), tiempoEspera, tiempoIntervalo);
    }

    void GenerarObjectAleatorio()
    {
        int indexAleatorio = Random.Range(0, Aleatorios);
        GameObject Proyectil1 = objectPool.GetPooledObject();
        GameObject Proyectil2 = objectPool.GetPooledObject1();
        if (indexAleatorio == 0 && Proyectil1 != null)
        {
            Proyectil1.transform.position = transform.position;
            Proyectil1.transform.rotation = Quaternion.identity;
            Proyectil1.SetActive(true);
        }
        if (indexAleatorio == 1 && Proyectil2 != null)
        {
            Proyectil2.transform.position = transform.position;
            Proyectil2.transform.rotation = Quaternion.identity;
            Proyectil2.SetActive(true);
        }
        //GameObject prefabAleatorio = objetosPrefabs[indexAleatorio];
        //Instantiate(prefabAleatorio, transform.position, Quaternion.identity);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("El SpriteRenderer deja de ser visible por las cámaras en la escena");
        CancelInvoke(nameof(GenerarObjectAleatorio));
    }

    private void OnBecameVisible()
    {
        Debug.Log("El SpriteRenderer es visible por las cámaras en la escena");
        InvokeRepeating(nameof(GenerarObjectAleatorio), tiempoEspera, tiempoIntervalo);
    }
}
