using UnityEngine;

public class Fruit : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }

            Destroy(gameObject);
        }
    }
}
