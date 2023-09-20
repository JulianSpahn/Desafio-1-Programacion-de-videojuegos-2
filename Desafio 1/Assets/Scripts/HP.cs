using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private float vida = 5f;

    public void ModificarVida(float puntos)
    {
        vida += puntos;
        Debug.Log(EstasVivo());
        if (!EstasVivo())
        {
            Debug.Log("Perdiste");
        }
    }


    private bool EstasVivo()
    {
        return vida >= 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        if (vida>=0)
        {
            Debug.Log("GANASTE");
        }
        else
        {
            Debug.Log("Perdiste");
        }
        


    }
}
