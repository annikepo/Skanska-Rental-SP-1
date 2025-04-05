using System.Collections.Generic;
using UnityEngine;

public class PanelManagerDisplayTemplateAR : MonoBehaviour

{
    // Public references to all panels in your UI
    public GameObject CallToActionPanel;
    public GameObject InformationPanel;
   

    // This method will hide all panels and show the desired one
    private void ShowPanel(GameObject panelToShow)
    {
        // Hide all panels
        CallToActionPanel.SetActive(false);
        InformationPanel.SetActive(false);
        

        // Show the selected panel
        panelToShow.SetActive(true);
    }

   
    // Called when the "CallToAction" button is clicked
    public void CallToActionButtonClicked()
    {
        ShowPanel(CallToActionPanel);
    }

    // Called when the "Information" button is clicked
    public void InformationButtonClicked()
    {
        ShowPanel(InformationPanel);
    }


    // Called when the "Close" button is clicked
    public void CloseButtonClicked()
    {
        CallToActionPanel.SetActive(false);
        InformationPanel.SetActive(false);
    }
}

