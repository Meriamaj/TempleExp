using UnityEngine;

public class ArtefactPickup : MonoBehaviour
{
    public static int artefactCount = 0; // commence à 0
    private ObjectiveManager objManager;

    private void Start()
    {
        objManager = FindObjectOfType<ObjectiveManager>();

        // Affiche correctement au lancement
        if (objManager != null)
        {
            objManager.SetObjective("Mission : Collecter les 3 artefacts (" + artefactCount + "/3)");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            artefactCount++;

            Debug.Log("Artefacts collectés = " + artefactCount);

            if (objManager != null)
            {
                if (artefactCount < 3)
                {
                    objManager.SetObjective("Mission : Collecter les 3 artefacts (" + artefactCount + "/3)");
                }
                else if (artefactCount == 3)
                {
                    objManager.SetObjective("Mission accomplie ! Trouve la porte mystique pour quitter la jungle.");
                }
            }

            Destroy(gameObject);
        }
    }
}
