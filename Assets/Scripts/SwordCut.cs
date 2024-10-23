using UnityEngine;

public class SwordCut : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruta") || other.CompareTag("Bomba"))
        {
            Destroy(other.gameObject);
        }
    }
}
