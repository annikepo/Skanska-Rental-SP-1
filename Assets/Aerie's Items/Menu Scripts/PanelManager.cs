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
        ShowPanel(SelectionPanel);
    }

    // Called when the "Browse" button is clicked
    public void OnBrowseButtonClicked()
    {
        ShowPanel(BrowsePanel);
    }

    // Called when the "Cabin" button is clicked
    public void OnCabinButtonClicked()
    {
        ShowPanel(CabinPanel);
    }

    // Called when the "Information" button is clicked
    public void OnInformationButtonClicked()
    {
        ShowPanel(InformationPanel);
    }

    // Called when the "My Projects" button is clicked
    public void OnMyProjectsButtonClicked()
    {
        ShowPanel(InputPanel);
    }

    // Called when the "Back to Login" button is clicked
    public void OnBackToLoginButtonClicked()
    {
        ShowPanel(LoginPanel);
    }
}

