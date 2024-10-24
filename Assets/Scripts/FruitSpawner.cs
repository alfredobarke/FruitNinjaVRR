using UnityEngine;

public class CannonFruitSpawner : MonoBehaviour
{
    public GameObject[] fruits; 
    public float initialSpawnInterval = 2f; // Intervalo inicial de generación
    public float maxSpawnInterval = 5f; // Intervalo máximo 
    public float incrementRate = 0.05f; // Cantidad de incremento

    public float minLaunchForce = 12f; // Fuerza mínima de lanzamiento
    public float maxLaunchForce = 18f; // Fuerza máxima de lanzamiento

    private float currentSpawnInterval;
    private Animator cannonAnimator;

    void Start()
    {
        cannonAnimator = GetComponentInParent<Animator>(); 
        currentSpawnInterval = initialSpawnInterval;
        Invoke("SpawnFruit", currentSpawnInterval);
    }

    void SpawnFruit()
    {
        
        int randomIndex = Random.Range(0, fruits.Length);
        GameObject fruit = Instantiate(fruits[randomIndex], transform.position, Quaternion.identity);

        
        Rigidbody rb = fruit.GetComponent<Rigidbody>();
        if (rb != null)
        {
            float launchForce = Random.Range(minLaunchForce, maxLaunchForce); 
            Vector3 launchDirection = new Vector3(Random.Range(-0.2f, 0.2f), 1, Random.Range(-0.2f, 0.2f)); 
            rb.AddForce(launchDirection.normalized * launchForce, ForceMode.Impulse);
        }

        if (cannonAnimator != null)
        {
            cannonAnimator.SetTrigger("Fire");
        }

        currentSpawnInterval = Mathf.Min(maxSpawnInterval, currentSpawnInterval + incrementRate);

        Invoke("SpawnFruit", currentSpawnInterval);
    }
}
