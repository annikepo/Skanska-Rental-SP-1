using UnityEngine;
using System.Collections;

public class LogoFadeOut : MonoBehaviour
{
    public CanvasGroup canvasGroup; // Drag your logo's CanvasGroup here
    public float delay = 3f;
    public float fadeDuration = 1f;

    void Start()
    {
        StartCoroutine(FadeOutLogo());
    }

    IEnumerator FadeOutLogo()
    {
        yield return new WaitForSeconds(delay);

        float t = 0f;
        float startAlpha = canvasGroup.alpha;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0f, t / fadeDuration);
            yield return null;
        }

        canvasGroup.alpha = 0f;
        canvasGroup.gameObject.SetActive(false); // fully hide it
    }
}
