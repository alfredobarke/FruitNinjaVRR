using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Image[] lifeIcons; // Array de iconos de corazones
    private int currentLives;

    void Start()
    {
        currentLives = lifeIcons.Length; // Inicializar el número de vidas según la cantidad de corazones
    }

    public void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--; // Reducir el número de vidas
            lifeIcons[currentLives].enabled = false; // Ocultar un corazón

            // Comprobar si el jugador se quedó sin vidas
            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!"); 
        // Aquí podrías agregar lógica adicional para terminar el juego, como mostrar un menú de Game Over
    }
}
