using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    // References to overlay panels
    public GameObject OverlayInfo;   // Panel for product details
    public GameObject OverlayRec;    // Panel for product recommendation

    // Buttons
    public Button tryInARButton;    // Button inside OverlayInfo
    public Button searchButton;     // Button to show OverlayRec
    public Button closeRecButton;   // Button to close OverlayRec
    public Button closeInfoButton;  // Button to close OverlayInfo

    void Start()
    {
        // Ensure both panels are hidden initially
        OverlayInfo.SetActive(false);
        OverlayRec.SetActive(false);

        // Set up button listeners
        if (tryInARButton != null)
            tryInARButton.onClick.AddListener(TransitionToAR);

        if (searchButton != null)
            searchButton.onClick.AddListener(ShowOverlayRec);

        if (closeRecButton != null)
            closeRecButton.onClick.AddListener(HideOverlayRec);

        if (closeInfoButton != null)
            closeInfoButton.onClick.AddListener(HideOverlayInfo);
    }

    // Show OverlayRec when search is clicked
    public void ShowOverlayRec()
    {
        OverlayRec.SetActive(true);
    }

    // Hide OverlayRec
    public void HideOverlayRec()
    {
        OverlayRec.SetActive(false);
    }

    // Show OverlayInfo (use this when a product is selected)
    public void ShowOverlayInfo()
    {
        OverlayInfo.SetActive(true);
    }

    // Hide OverlayInfo
    public void HideOverlayInfo()
    {
        OverlayInfo.SetActive(false);
    }

    // Navigate to AR Scene
    private void TransitionToAR()
    {
        Debug.Log("Navigating to AR scene...");
        // Example: SceneManager.LoadScene("ARScene");
    }
}
