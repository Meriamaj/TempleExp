using UnityEngine;
using TMPro;

public class MissionMessage2 : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public CanvasGroup canvasGroup;

    public void ShowMessage(string msg, float duration = 3f)
    {
        StopAllCoroutines();
        StartCoroutine(ShowRoutine(msg, duration));
    }

    private System.Collections.IEnumerator ShowRoutine(string msg, float duration)
    {
        messageText.text = msg;

        // Fade IN
        for (float t = 0; t < 1f; t += Time.deltaTime * 2)
        {
            canvasGroup.alpha = t;
            yield return null;
        }
        canvasGroup.alpha = 1;

        // Wait
        yield return new WaitForSeconds(duration);

        // Fade OUT
        for (float t = 1f; t > 0f; t -= Time.deltaTime * 2)
        {
            canvasGroup.alpha = t;
            yield return null;
        }
        canvasGroup.alpha = 0;
    }
}
