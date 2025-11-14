using UnityEngine;
using UnityEngine.SceneManagement;

public class TempleDoor : MonoBehaviour
{
    public string nextSceneName = "TempleScene"; 
    private ObjectiveManager objManager;

    private void Start()
    {
        objManager = FindObjectOfType<ObjectiveManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (ArtefactPickup.artefactCount >= 3)
            {
                if (objManager != null)
                {
                    objManager.SetObjective("Accès au Temple ! Chargement du prochain niveau...");
                }

                // Charge la scène du temple
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                if (objManager != null)
                {
                    objManager.SetObjective("Tu dois d'abord collecter les 3 artefacts pour ouvrir cette porte !");
                }
            }
        }
    }
}
