
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadARScene()
    {
        Debug.Log("Navigating to AR scene...");
        SceneManager.LoadScene("DisplayBrowserAR"); // must match the scene name
    }
}
