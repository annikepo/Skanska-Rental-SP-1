using UnityEngine;
using System.Collections.Generic;

public class PanelManager : MonoBehaviour
{
    // Public references to all panels in your UI
    public GameObject LoginPanel;
    public GameObject SelectionPanel;
    public GameObject BrowsePanel;
    public GameObject CabinPanel;
    public GameObject InformationPanel;
    public GameObject InputPanel;

    // Stack to keep track of the panel history
    private Stack<GameObject> panelHistory = new Stack<GameObject>();

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

        // Push the current panel onto the history stack
        panelHistory.Push(panelToShow);
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

    // Called when the "My Project" button is clicked
    public void OnMyProjectButtonClicked()
    {
        ShowPanel(InputPanel);
    }

    // Called when the "Back to previous panel" button is clicked
    public void OnBackButtonClicked()
    {
        if (panelHistory.Count > 1) // Check if there's more than one panel in history
        {
            // Pop the current panel (the one on top of the stack)
            panelHistory.Pop();

            // Get the previous panel in the history stack
            GameObject previousPanel = panelHistory.Peek();

            // Show the previous panel
            ShowPanel(previousPanel);
        }
        else
        {
            Debug.Log("No previous panel to go back to.");
        }
    }
}
