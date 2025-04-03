using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class RenderPipelineSwitcher : MonoBehaviour
{
    public RenderPipelineAsset arPipeline;      // Assign Mobile AR pipeline here
    public RenderPipelineAsset defaultPipeline; // Assign your default pipeline

    void Start()
    {
        if (arPipeline != null)
        {
            GraphicsSettings.defaultRenderPipeline = arPipeline;
            Debug.Log("Switched to AR Render Pipeline");
        }

        // Listen for scene changes
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // If it's not the AR scene, switch back
        if (scene.name != "DisplayTemplate AR" && defaultPipeline != null)
        {
            GraphicsSettings.defaultRenderPipeline = defaultPipeline;
            Debug.Log("Switched back to Default Render Pipeline");
        }
    }

    void OnDestroy()
    {
        // Remove scene change listener to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}