using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObjetoAleatorio : MonoBehaviour
{
    [SerializeField] private GameObject[] objetosPrefabs;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoEspera;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoIntervalo;

    void Start()
    {
        //InvokeRepeating(nameof(GenerarObjectAleatorio), tiempoEspera, tiempoIntervalo);
    }

    void GenerarObjectAleatorio()
    {
        int indexAleatorio = Random.Range(0, objetosPrefabs.Length);
        GameObject prefabAleatorio = objetosPrefabs[indexAleatorio];
        Instantiate(prefabAleatorio, transform.position, Quaternion.identity);
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
