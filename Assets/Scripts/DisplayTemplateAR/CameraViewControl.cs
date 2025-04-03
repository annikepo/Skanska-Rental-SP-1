using UnityEngine;

public class CameraViewControl : MonoBehaviour
{
    public Transform cameraTransform;  // The main camera transform (drag here in Inspector)
    public Transform miniatureTransform;  // The miniature object transform (drag here in Inspector)
    public float viewSpeed = 10f;  // Speed for the camera view change
    public float maxAngle = 80f;  // Maximum tilt angle (top view)
    public float minAngle = 10f;  // Minimum tilt angle (side view)
    private float currentAngle = 45f; // Default starting angle

    private bool isIncreasing = false;
    private bool isDecreasing = false;

    void Update()
    {
        // Smoothly interpolate the camera's angle to the desired view angle
        if (isIncreasing)
        {
            currentAngle = Mathf.Min(currentAngle + viewSpeed * Time.deltaTime, maxAngle);
        }
        if (isDecreasing)
        {
            currentAngle = Mathf.Max(currentAngle - viewSpeed * Time.deltaTime, minAngle);
        }

        // Apply the calculated angle to the camera's rotation
        cameraTransform.rotation = Quaternion.Euler(currentAngle, cameraTransform.eulerAngles.y, cameraTransform.eulerAngles.z);

        // Ensure the miniature stays in front of the camera, update its position once per frame
        UpdateMiniaturePosition();
    }

    // Start increasing view angle when the button is pressed
    public void StartIncreaseViewAngle()
    {
        isIncreasing = true;
    }

    // Stop increasing view angle when the button is released
    public void StopIncreaseViewAngle()
    {
        isIncreasing = false;
    }

    // Start decreasing view angle when the button is pressed
    public void StartDecreaseViewAngle()
    {
        isDecreasing = true;
    }

    // Stop decreasing view angle when the button is released
    public void StopDecreaseViewAngle()
    {
        isDecreasing = false;
    }

    // Ensure the miniature stays in front of the camera
    private void UpdateMiniaturePosition()
    {
        // Keep the miniature at a fixed distance in front of the camera
        Vector3 cameraPosition = cameraTransform.position;
        Vector3 forwardDirection = cameraTransform.forward;

        // Position the miniature slightly in front of the camera and keep it at a fixed distance
        miniatureTransform.position = cameraPosition + forwardDirection * 0.5f; // Adjust 0.5f for distance
    }
}
