using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarObjeto : MonoBehaviour
{
    [SerializeField] private GameObject objetoPrefab;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoEspera;

    void Start()
    {
        Invoke("GenerarObject", tiempoEspera);
    }

    void GenerarObject()
    {
        Instantiate(objetoPrefab, transform.position, Quaternion.identity);
    }
}
