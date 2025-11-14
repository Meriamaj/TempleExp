using UnityEngine;
using TMPro;


public class MissionManager : MonoBehaviour
{
    public static MissionManager Instance;

    [Header("UI")]
    public TextMeshProUGUI missionText;

    [Header("Progression")]
    public int artefactsCollected = -2;
    public int artefactsNeeded = 3;

    private bool allArtefactsCollected = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        missionText.text = "Mission : Collectez les 3 artefacts.";
    }

    public void AddArtefact()
    {
        artefactsCollected++;

        if (artefactsCollected < artefactsNeeded)
        {
            missionText.text =
                "Artefacts collectés : " + artefactsCollected + " / " + artefactsNeeded;
        }
        else if (!allArtefactsCollected)
        {
            allArtefactsCollected = true;
            missionText.text =
                "Tous les artefacts collectés ! Trouvez la porte du temple.";
        }
    }

    public void EnterTemple()
    {
        if (allArtefactsCollected)
        {
            missionText.text = "Mission accomplie ! Vous entrez dans le temple...";
            // Ici tu peux charger ton niveau suivant
            // SceneManager.LoadScene("NextLevel");
        }
        else
        {
            missionText.text = "Vous devez d'abord collecter les 3 artefacts.";
        }
    }
}
