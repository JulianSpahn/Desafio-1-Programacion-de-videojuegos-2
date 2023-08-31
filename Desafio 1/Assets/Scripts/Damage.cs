using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] float puntos = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HP jugador = collision.gameObject.GetComponent<HP>();
            jugador.ModificarVida(-puntos);
            Debug.Log(" PUNTOS DE DA�O REALIZADOS AL JUGADOR " + puntos);
        }
    }
}
