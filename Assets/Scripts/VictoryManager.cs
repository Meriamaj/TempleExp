using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryManager : MonoBehaviour
{
    public GameObject victoryUI;

    public void ShowVictory()
    {
        victoryUI.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
