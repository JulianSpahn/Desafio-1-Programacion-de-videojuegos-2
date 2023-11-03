using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilDamage : MonoBehaviour
{
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] int puntos = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HP jugador = collision.gameObject.GetComponent<HP>();
            jugador.ModificarVida(-puntos);
            Debug.Log(" PUNTOS DE DAÑO REALIZADOS AL JUGADOR " + puntos);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Untagged"))
        {
            gameObject.SetActive(false);
        }
    }
}
