using UnityEngine;
using UnityEngine.UI;

public class ScaleMiniature : MonoBehaviour
{
    public Transform miniature;
    public Slider scaleSlider;
    public float minScale = 0.5f;
    public float maxScale = 2f;

    void Start()
    {
        scaleSlider.minValue = minScale;
        scaleSlider.maxValue = maxScale;
        scaleSlider.onValueChanged.AddListener(ChangeScale);
    }

    // set scale
    public void ChangeScale(float value)
    {
        if (miniature != null)
        {
            miniature.localScale = Vector3.one * value;
        }
    }
}