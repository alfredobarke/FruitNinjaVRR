using UnityEngine;

public class CannonFruitSpawner : MonoBehaviour
{
    public GameObject[] fruits; // Array de frutas y bombas
    public float initialSpawnInterval = 2f; // Intervalo inicial de generación
    public float maxSpawnInterval = 5f; // Intervalo máximo para hacerlo más fácil
    public float incrementRate = 0.05f; // Cantidad de incremento del intervalo en cada iteración

    public float minLaunchForce = 12f; // Fuerza mínima de lanzamiento
    public float maxLaunchForce = 18f; // Fuerza máxima de lanzamiento

    private float currentSpawnInterval;
    private Animator cannonAnimator;

    void Start()
    {
        cannonAnimator = GetComponentInParent<Animator>(); // El Animator está en el cañón
        currentSpawnInterval = initialSpawnInterval;
        Invoke("SpawnFruit", currentSpawnInterval);
    }

    void SpawnFruit()
    {
        // Crear la fruta
        int randomIndex = Random.Range(0, fruits.Length);
        GameObject fruit = Instantiate(fruits[randomIndex], transform.position, Quaternion.identity);

        // Aplicar una fuerza al Rigidbody para lanzar la fruta
        Rigidbody rb = fruit.GetComponent<Rigidbody>();
        if (rb != null)
        {
            float launchForce = Random.Range(minLaunchForce, maxLaunchForce); // Seleccionar una fuerza de lanzamiento aleatoria
            Vector3 launchDirection = new Vector3(Random.Range(-0.2f, 0.2f), 1, Random.Range(-0.2f, 0.2f)); // Dirección con ligera variación
            rb.AddForce(launchDirection.normalized * launchForce, ForceMode.Impulse);
        }

        // Activar la animación de disparo del cañón
        if (cannonAnimator != null)
        {
            cannonAnimator.SetTrigger("Fire");
        }

        // Aumentar gradualmente el intervalo de generación
        currentSpawnInterval = Mathf.Min(maxSpawnInterval, currentSpawnInterval + incrementRate);

        // Invocar nuevamente el método con el nuevo intervalo
        Invoke("SpawnFruit", currentSpawnInterval);
    }
}
