using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al componente Text Mesh Pro en el canvas
    private int score;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddPoint()
    {
        score += 1; // Sumar un punto por cada corte
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Puntos: " + score;
    }
}
