using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackgroundSlider : MonoBehaviour
{
    public Image backgroundImage;
    public Sprite[] backgrounds;
    public float fadeDuration = 1f;
    public float timeBetweenSlides = 4f;

    private int currentIndex = 0;

    void Start()
    {
        StartCoroutine(SlideShow());
    }

    IEnumerator SlideShow()
    {
        while (true)
        {
            Sprite next = backgrounds[currentIndex];
            yield return StartCoroutine(FadeTo(next));
            yield return new WaitForSeconds(timeBetweenSlides);

            currentIndex = (currentIndex + 1) % backgrounds.Length;
        }
    }

    IEnumerator FadeTo(Sprite newSprite)
    {
        float t = 0;
        Color c = backgroundImage.color;

        // Fade out
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            backgroundImage.color = new Color(c.r, c.g, c.b, 1 - t / fadeDuration);
            yield return null;
        }

        backgroundImage.sprite = newSprite;

        // Fade in
        t = 0;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            backgroundImage.color = new Color(c.r, c.g, c.b, t / fadeDuration);
            yield return null;
        }

        backgroundImage.color = new Color(c.r, c.g, c.b, 1f);
    }
}

