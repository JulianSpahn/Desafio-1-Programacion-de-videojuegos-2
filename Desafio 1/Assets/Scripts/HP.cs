using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField]
    private PerfilJugador perfilJugador;
    public PerfilJugador PerfilJugador { get => perfilJugador; }

    public void ModificarVida(float puntos)
    {
        perfilJugador.Vida += puntos;
        Debug.Log(EstasVivo());
        if (!EstasVivo())
        {
            Debug.Log("Perdiste");
        }
    }


    private bool EstasVivo()
    {
        return perfilJugador.Vida >= 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        if (perfilJugador.Vida>=0)
        {
            Debug.Log("GANASTE");
        }
        else
        {
            Debug.Log("Perdiste");
        }
        


    }
}
