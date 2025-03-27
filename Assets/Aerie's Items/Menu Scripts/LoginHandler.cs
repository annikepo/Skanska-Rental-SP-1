using UnityEngine;

public class LoginHandler : MonoBehaviour
{
    public GameObject LoginPanel;
    public GameObject SelectionPanel;

    public void OnSignInButtonClicked()
    {
        LoginPanel.SetActive(false);
        SelectionPanel.SetActive(true);
    }
}
