using UnityEngine;
using TMPro;

public class ArtefactCollector : MonoBehaviour
{
    public int artefactCount = 0;
    public int totalArtefacts = 3;
    public TextMeshProUGUI artefactText;
    public GameObject templeDoor;

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Artefact"))
        {
            artefactCount++;
            Destroy(other.gameObject);
            UpdateUI();

            if (artefactCount >= totalArtefacts)
            {
                OpenTempleDoor();
            }
        }
    }

    void UpdateUI()
    {
        if (artefactText != null)
            artefactText.text = "Artefacts : " + artefactCount + "/" + totalArtefacts;
    }

    void OpenTempleDoor()
    {
        if (templeDoor != null)
        {
            Animator animator = templeDoor.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("Open");
            }
            else
            {
                Debug.LogWarning("No Animator found on templeDoor!");
            }
        }
    }

}
