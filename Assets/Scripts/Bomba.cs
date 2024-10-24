using UnityEngine;

public class Bomba : MonoBehaviour
{
    public LifeManager lifeManager;

    private void Start()
    {
        if (lifeManager == null)
        {
            lifeManager = GameObject.FindObjectOfType<LifeManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            if (lifeManager != null)
            {
                lifeManager.LoseLife(); // reduce una vida si la bomba toca la espada
                Destroy(gameObject); 
            }
        }
    }
}
