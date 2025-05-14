
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneLoader : MonoBehaviour
{
    public void LoadDisplayBrowserAR()
    {
        Debug.Log("✅ Loading AR scene...");
        SceneManager.LoadScene("DisplayBrowserAR", LoadSceneMode.Single);
    }
}
