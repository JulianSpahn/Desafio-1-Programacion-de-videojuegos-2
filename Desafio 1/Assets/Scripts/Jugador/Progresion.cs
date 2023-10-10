using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresion : MonoBehaviour
{
    private HP jugador;

    private void Awake()
    {
        jugador = GetComponent<HP>();
    }

    public void GanarExperiencia(int nuevaExperiencia)
    {
        jugador.PerfilJugador.Experiencia += nuevaExperiencia;

        if (jugador.PerfilJugador.Experiencia >= jugador.PerfilJugador.ExperienciaProximoNivel)
        {
            SubirNivel();
        }
       // Debug.Log(nuevaExperiencia);
    }

    private void SubirNivel()
    {
        jugador.PerfilJugador.Nivel++;
        jugador.PerfilJugador.Experiencia -= jugador.PerfilJugador.ExperienciaProximoNivel;
        jugador.PerfilJugador.ExperienciaProximoNivel += jugador.PerfilJugador.EscalarExperiencia;
    }
}
