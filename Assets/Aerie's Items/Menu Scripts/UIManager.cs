using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelLogin;
    public GameObject panelMainMenu;

    public void GoToMainMenu()
    {
        panelLogin.SetActive(false);
        panelMainMenu.SetActive(true);
    }
}
