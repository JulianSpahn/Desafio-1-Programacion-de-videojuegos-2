using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] int puntos = 1;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Player"))
        {
            HP jugador = other.GetComponent<HP>();
            jugador.ModificarVida(puntos);
            Debug.Log(" PUNTOS DE VIDA RECUPERADOS: + " + puntos);
        }
    }
}
