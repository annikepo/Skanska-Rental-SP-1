using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject browsePanel; // Rename this if yours is called SecondScreen

    public void OnSignInButtonClicked()
    {
        loginPanel.SetActive(false);
        browsePanel.SetActive(true);
    }
}
