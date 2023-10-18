using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HP : MonoBehaviour
{
    [SerializeField]
    private PerfilJugador perfilJugador;
    public PerfilJugador PerfilJugador { get => perfilJugador; }

    [SerializeField]
    private UnityEvent<int> OnLivesChanged;

    [SerializeField]
    private UnityEvent<string> OnTextChanged;
    private void Start()
    {
        OnLivesChanged.Invoke(perfilJugador.Vida);
        OnTextChanged.Invoke(perfilJugador.Vida.ToString());
    }

    public void ModificarVida(int puntos)
    {
        perfilJugador.Vida += puntos;
        OnTextChanged.Invoke(perfilJugador.Vida.ToString());
        OnLivesChanged.Invoke(perfilJugador.Vida);
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
