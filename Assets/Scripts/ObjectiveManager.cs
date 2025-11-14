using TMPro;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;

    void Start()
    {
        SetObjective("Mission : Collecter les 3 artefacts (0/3)");
    }

    public void SetObjective(string txt)
    {
        if (objectiveText != null)
        {
            objectiveText.text = txt;
        }
        else
        {
            Debug.LogWarning("ObjectiveText n'est pas assigné dans ObjectiveManager !");
        }
    }
}
