using UnityEngine;
using UnityEngine.SceneManagement;

public class Movescene : MonoBehaviour
{
    public void LoadDisplayBrowserAR()
    {
        Debug.Log("✅ Loading AR scene...");
        SceneManager.LoadScene("DisplayBrowserAR", LoadSceneMode.Single);
    }
}