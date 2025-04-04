
    using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadDisplayBrowserAR()
    {
        Debug.Log("✅ Button pressed! Scene load should happen now.");
        SceneManager.LoadScene("DisplayBrowserAR");
    }
}
