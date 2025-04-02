
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu Scene"); // ← Make sure this name matches your menu scene exactly!
    }
}
