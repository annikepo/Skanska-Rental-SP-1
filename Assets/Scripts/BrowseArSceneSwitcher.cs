using UnityEngine;
using UnityEngine.SceneManagement;

public class BrowseArSceneSwitcher : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("DisplayBrowserAR", LoadSceneMode.Single);
    }
}
