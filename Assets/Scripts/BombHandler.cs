using UnityEngine;

public class BombHandler : MonoBehaviour
{
    public LifeManager lifeManager; // Referencia al sistema de vidas

    void Start()
    {
        // Buscar el LifeManager automáticamente al iniciar
        lifeManager = FindObjectOfType<LifeManager>();
        if (lifeManager == null)
        {
            Debug.LogError("LifeManager no encontrado en la escena.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            // Restar una vida si la espada toca la bomba
            if (lifeManager != null)
            {
                lifeManager.LoseLife();
            }
            // Destruir la bomba
            Destroy(gameObject);
        }
    }
}
