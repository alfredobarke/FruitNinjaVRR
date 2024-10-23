using UnityEngine;

public class Fruit : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // Buscar el ScoreManager automáticamente al iniciar
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            // Añadir un punto al puntaje
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }

            // Destruir la fruta cortada
            Destroy(gameObject);
        }
    }
}
