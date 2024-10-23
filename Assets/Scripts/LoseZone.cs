using UnityEngine;

public class LoseZone : MonoBehaviour
{
    public LifeManager lifeManager; // Referencia al sistema de vidas

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruta"))
        {
            // Restar una vida y destruir la fruta
            lifeManager.LoseLife();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bomba"))
        {
            // Destruir la bomba sin afectar las vidas
            Destroy(other.gameObject);
        }
    }
}
