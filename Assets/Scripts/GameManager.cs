using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float initialDelay = 10f;
    public float additionalDelay = 20f;
    private GameObject[] cannons;

    void Start()
    {
        cannons = GameObject.FindGameObjectsWithTag("Cannon");

        if (cannons.Length > 0)
        {
            for (int i = 1; i < cannons.Length; i++)
            {
                cannons[i].SetActive(false);
            }
        }

        if (cannons.Length > 1)
        {
            Invoke("ActivateSecondCannon", initialDelay);
        }

        if (cannons.Length > 2)
        {
            Invoke("ActivateThirdCannon", initialDelay + additionalDelay);
        }
    }

    void ActivateSecondCannon()
    {
        if (cannons.Length > 1)
        {
            cannons[1].SetActive(true);
        }
    }

    void ActivateThirdCannon()
    {
        if (cannons.Length > 2)
        {
            cannons[2].SetActive(true);
        }
    }
}
