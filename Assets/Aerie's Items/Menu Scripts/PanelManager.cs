using UnityEngine;

public class PanelManager : MonoBehaviour
{
    // Public references to all panels in your UI
    public GameObject LoginPanel;
    public GameObject SelectionPanel;
    public GameObject BrowsePanel;
    public GameObject CabinPanel;
    public GameObject InformationPanel;
    public GameObject InputPanel;

    // This method will hide all panels and show the desired one
    private void ShowPanel(GameObject panelToShow)
    {
        // Hide all panels
        LoginPanel.SetActive(false);
        SelectionPanel.SetActive(false);
        BrowsePanel.SetActive(false);
        CabinPanel.SetActive(false);
        InformationPanel.SetActive(false);
        InputPanel.SetActive(false);

        // Show the selected panel
        panelToShow.SetActive(true);
    }

    // Called when the "Sign In" button is clicked
    public void OnSignInButtonClicked()
    {
        Debug.Log("Navigating to Selection Panel");
        ShowPanel(SelectionPanel);
    }

    // Called when the "Browse Products" button is clicked
    public void OnBrowseButtonClicked()
    {
        Debug.Log("Navigating to Browse Panel");
        ShowPanel(BrowsePanel);
    }

    // Called when the "Cabin" button is clicked
    public void OnCabinButtonClicked()
    {
        Debug.Log("Navigating to Cabin Panel");
        ShowPanel(CabinPanel);
    }

    // Called when the "Information" button is clicked
    public void OnInformationButtonClicked()
    {
        Debug.Log("Navigating to Information Panel");
        ShowPanel(InformationPanel);
    }

    // Called when the "My Projects" button is clicked
    public void OnMyProjectsButtonClicked()
    {
        Debug.Log("Navigating to Input Panel");
        ShowPanel(InputPanel);
    }

    // Called when the "Back to Login" button is clicked
    public void OnBackToLoginButtonClicked()
    {
        Debug.Log("Navigating to Login Panel");
        ShowPanel(LoginPanel);
    }
}
