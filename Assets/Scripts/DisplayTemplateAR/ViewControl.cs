using UnityEngine;

public class ViewControl : MonoBehaviour
{
    public float minAngle = 10f;  // Prevent looking underneath
    public float maxAngle = 90f;  // Fully top-down view
    public float angleStep = 1f;  // Angle change per frame when held
    public float transitionSpeed = 5f; // Smooth rotation speed
    public GameObject floorplanImage; // Optional floorplan image at 90 degrees

    private float targetAngle = 30f; // Default start angle
    private bool isIncreasing = false;
    private bool isDecreasing = false;

    void Update()
    {
        // Smooth transition to the target angle (pitch of X-axis)
        Vector3 currentRotation = transform.eulerAngles;
        float newX = Mathf.LerpAngle(currentRotation.x, targetAngle, Time.deltaTime * transitionSpeed);
        transform.rotation = Quaternion.Euler(newX, currentRotation.y, currentRotation.z);

        // Show floorplan image if at 90 degrees
        if (floorplanImage != null)
        {
            floorplanImage.SetActive(targetAngle >= maxAngle);
        }

        // Continuously change angle while buttons are held
        if (isIncreasing)
        {
            targetAngle = Mathf.Clamp(targetAngle - angleStep, minAngle, maxAngle);  // Reduce X to go top-down
        }
        if (isDecreasing)
        {
            targetAngle = Mathf.Clamp(targetAngle + angleStep, minAngle, maxAngle);  // Increase X to tilt more
        }
    }

    public void StartIncreaseViewAngle()
    {
        isIncreasing = true;
    }

    public void StopIncreaseViewAngle()
    {
        isIncreasing = false;
    }

    public void StartDecreaseViewAngle()
    {
        isDecreasing = true;
    }

    public void StopDecreaseViewAngle()
    {
        isDecreasing = false;
    }
}