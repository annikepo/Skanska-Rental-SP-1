
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARPlacementController : MonoBehaviour
{
    public GameObject objectToPlace;
    public GameObject placementIndicator;

    private ARRaycastManager raycastManager;
    private GameObject spawnedObject;
    private Pose placementPose;
    private bool placementPoseIsValid;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        placementIndicator.SetActive(false);
    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();

        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (spawnedObject == null)
                spawnedObject = Instantiate(objectToPlace, placementPose.position, placementPose.rotation);
            else
                MoveObject();
        }
    }

    void UpdatePlacementPose()
    {
        if (Camera.main == null) return; // safely return if no camera found
        Vector3 screenCenter = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
            placementPose = hits[0].pose;
    }

    void UpdatePlacementIndicator()
    {
        if (spawnedObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    void MoveObject()
    {
        spawnedObject.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
    }
}
