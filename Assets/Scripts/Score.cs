using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    void Start()
    {
        ActualizarTexto();
    }
    void ActualizarTexto()
    {
        scoreText.text = "Score: " + score + " Points";
    }

    public void Contador(int sumarPuntos)
    {
        score += sumarPuntos;
        ActualizarTexto();

    }
}
