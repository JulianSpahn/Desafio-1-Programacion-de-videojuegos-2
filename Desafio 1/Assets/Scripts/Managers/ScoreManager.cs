using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    private int score;
    private int highScore;

    private void Start()
    {
        // Carga el puntaje máximo guardado previamente, si existe.
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }

    public void AddScore(int points)
    {
        // Incrementa el puntaje actual y actualiza el texto en pantalla.
        score += points;
        UpdateScoreText();

        // Comprueba si se ha superado el puntaje máximo y actualiza en consecuencia.
        if (score > highScore)
        {
            highScore = score;
            UpdateHighScoreText();
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore;
    }
}
