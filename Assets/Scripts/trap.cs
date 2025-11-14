using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Quelque chose est entré dans le piège: " + other.name);

        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameOverManager>().ShowGameOver();
        }
    }
}

