using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObjetoLoop : MonoBehaviour
{
    [SerializeField] private GameObject objetoPrefab;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoEspera;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoIntervalo;

    void Start()
    {
        InvokeRepeating(nameof(GenerarObjectLoop), tiempoEspera, tiempoIntervalo);
    }

    void GenerarObjectLoop()
    {
        Instantiate(objetoPrefab, transform.position, Quaternion.identity);
    }
}
