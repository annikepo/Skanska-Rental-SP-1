using UnityEngine;
using UnityEngine.UI;  // For buttons
using TMPro; // For TextMeshPro if you want to modify text

public class ProductInfo : MonoBehaviour
{
    // Reference to the OverlayInfo panel and its elements
    public GameObject OverlayInfo;    // The overlay panel
    public GameObject Plan;           // The Plan child (you can modify as needed)
    public Button tryInARButton;      // Button for "Try in AR"
    

    void Start()
    {
        // Ensure OverlayInfo is hidden by default
        OverlayInfo.SetActive(false);

        // Set up button click listener
        tryInARButton.onClick.AddListener(OnTryInARClick);
    }

    // Method to show the overlay panel with the product info
    public void ShowOverlay(string productInfo)
    {
        

        // Activate the OverlayInfo panel
        OverlayInfo.SetActive(true);
    }

    // Button click method to transition to AR visualization
    private void OnTryInARClick()
    {
        // Example logic for AR scene transition
        // Assuming you have a method to handle the AR scene transition
        TransitionToAR();
    }

    // Method to transition to the AR scene (implement this as per your AR setup)
    private void TransitionToAR()
    {
        // Example: Load AR scene or activate AR functionality here
        Debug.Log("Navigating to AR scene...");
        // You might use SceneManager to load the AR scene:
        // SceneManager.LoadScene("ARScene");
    }

    // You can call this method when an item is selected in the scroll view
    // Pass the information about the product to the overlay
    public void OnProductSelected(string productInfo)
    {
        ShowOverlay(productInfo);
    }
}
