using UnityEngine;
using UnityEngine.UI;

public class FinalTreasure : MonoBehaviour
{
    public GameObject victoryUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trésor final collecté !");
            victoryUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f; // Freeze the game
        }
    }
}
