using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad = "TempleScene";

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger touched by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER DETECTED - Loading Scene...");
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
