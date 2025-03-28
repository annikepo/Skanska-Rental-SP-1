using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class ARProductPlacement : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject productPrefab;
    public ProductLockPlacement placementLock;

    private GameObject spawnedProduct;
    private Vector2 screenCenter;
    private bool planeDetected;

    void Start()
    {
        screenCenter = new Vector2(Screen.width / 2f, Screen.height / 2f);
        SpawnProductInSpace();
    }

    void Update()
    {
        if (placementLock != null && placementLock.IsLocked())
            return;

        if (TryGetPlanePosition(out Vector3 hitPosition))
        {
            if (spawnedProduct != null)
            {
                spawnedProduct.transform.position = hitPosition;
                planeDetected = true;
            }
        }
        else
        {
            if (spawnedProduct != null)
            {
                if (planeDetected)
                {
                    // If plane was detected before but lost, keep it at last known position
                    return;
                }
                spawnedProduct.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 0.5f;
                planeDetected = false;
            }
        }

        HandleTouchInput();
    }

    private bool TryGetPlanePosition(out Vector3 hitPosition)
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (raycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon))
        {
            hitPosition = hits[0].pose.position;
            return true;
        }
        hitPosition = Vector3.zero;
        return false;
    }

    private void SpawnProductInSpace()
    {
        if (productPrefab != null)
        {
            Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * 0.5f;
            spawnedProduct = Instantiate(productPrefab, spawnPosition, Quaternion.identity);
        }
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Touch touch = Input.GetTouch(0);
            float rotationSpeed = 0.2f;

            spawnedProduct.transform.Rotate(Vector3.up, -touch.deltaPosition.x * rotationSpeed, Space.World);
            spawnedProduct.transform.Rotate(Vector3.right, touch.deltaPosition.y * rotationSpeed, Space.Self);
        }
    }
}
