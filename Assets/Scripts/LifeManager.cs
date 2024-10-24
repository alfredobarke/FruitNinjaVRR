using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public Image[] lifeIcons; 
    private int currentLives;

    public TextMeshProUGUI gameOverText; 

    void Start()
    {
        currentLives = lifeIcons.Length;
        gameOverText.gameObject.SetActive(false); 
    }

    public void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--; 
            lifeIcons[currentLives].enabled = false; 

            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        
        gameOverText.gameObject.SetActive(true);

       
        Invoke("RestartGame", 5.0f); 
    }

    void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
