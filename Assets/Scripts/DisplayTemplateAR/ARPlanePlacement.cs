using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARPlanePlacement : MonoBehaviour
{
    public ARRaycastManager raycastManager;  // Assign ARRaycastManager from scene
    public GameObject miniatureObject;       // Assign the spawned miniature
    public bool usePlanePlacement = true;    // Toggle for plane placement

    private Vector2 screenCenter;

    void Start()
    {
        screenCenter = new Vector2(Screen.width / 2f, Screen.height / 2f);
    }

    void Update()
    {
        if (miniatureObject == null || raycastManager == null) return;

        if (!usePlanePlacement) return; // If disabled, do nothing

        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        // Try detecting a horizontal plane
        if (raycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon))
        {
            Vector3 hitPosition = hits[0].pose.position;
            miniatureObject.transform.position = hitPosition;
        }
    }

    public void TogglePlanePlacement()
    {
        usePlanePlacement = !usePlanePlacement;
        Debug.Log("Plane placement toggled: " + usePlanePlacement);
    }
}