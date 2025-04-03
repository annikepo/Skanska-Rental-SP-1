using UnityEngine;

public class ARMiniatureSpawner : MonoBehaviour
{
    public GameObject miniaturePrefab;  // Assign the prefab in the Inspector
    public float spawnDistance = 0.5f;  // Distance in front of the camera

    private GameObject spawnedMiniature;

    void Start()
    {
        SpawnMiniature();
    }

    private void SpawnMiniature()
    {
        if (miniaturePrefab == null)
        {
            Debug.LogError("Miniature Prefab is not assigned!");
            return;
        }

        // Spawn in front of the camera
        Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * spawnDistance;
        spawnedMiniature = Instantiate(miniaturePrefab, spawnPosition, Quaternion.identity);
    }
}