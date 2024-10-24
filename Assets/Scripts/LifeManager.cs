using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public Image[] lifeIcons; 
    private int currentLives;

    void Start()
    {
        currentLives = lifeIcons.Length; 
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
        Debug.Log("Game Over!"); 
        
    }
}
