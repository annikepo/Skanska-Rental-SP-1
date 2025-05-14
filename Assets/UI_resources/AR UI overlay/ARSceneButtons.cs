using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneButtons : MonoBehaviour
{
    public GameObject customerServicePanel; // Assign in Inspector

    // Method to go back to the SelectionPanel in the main menu scene
    public void GoToHome()
    {
        SceneManager.LoadScene("MainMenuScene"); // Replace with your actual main menu scene name
    }

    // Method to toggle the Customer Service panel visibility
    public void ToggleCustomerService()
    {
        customerServicePanel.SetActive(!customerServicePanel.activeSelf);
    }
}
