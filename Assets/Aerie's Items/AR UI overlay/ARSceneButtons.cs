using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneButtons : MonoBehaviour
{
    public GameObject customerServicePanel; // Assign this in the inspector
    public static bool returnToSelection = false; // Static flag to track if returning to SelectionPanel

    // Method for the Home button
    public void OnHomeButtonClicked()
    {
        returnToSelection = true; // Set flag to activate SelectionPanel
        SceneManager.LoadScene("MainMenuScene"); // Load Main Menu Scene
    }

    // Method for the Customer Service button
    public void OnCustomerServiceButtonClicked()
    {
        customerServicePanel.SetActive(true); // Show the customer service info panel
    }

    // Method to close the Customer Service panel
    public void OnCloseCustomerService()
    {
        customerServicePanel.SetActive(false);
    }
}
