using UnityEngine;

public class LoseZone : MonoBehaviour
{
    public LifeManager lifeManager; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruta"))
        {
            
            if (lifeManager != null)
            {
                lifeManager.LoseLife();
            }
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bomba"))
        {
        
            Destroy(other.gameObject);
        }
    }
}
