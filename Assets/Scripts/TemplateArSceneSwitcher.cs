using UnityEngine;
using UnityEngine.SceneManagement;

public class TemplateArSceneSwitcher : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("DisplayTemplateAR", LoadSceneMode.Single);
    }
}
