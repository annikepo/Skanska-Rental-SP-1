
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMainMenuFromDisplayTemplateAR : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu Scene"); // ← Make sure this name matches your menu scene exactly!
    }
}
