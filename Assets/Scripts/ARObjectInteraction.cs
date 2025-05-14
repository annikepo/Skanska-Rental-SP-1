using UnityEngine;

public class ARObjectInteraction : MonoBehaviour
{
    private float rotationSpeed = 0.2f;
    private float scaleSpeed = 0.005f;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            RotateObject(Input.GetTouch(0));
        }
        else if (Input.touchCount == 2)
        {
            ScaleObject(Input.GetTouch(0), Input.GetTouch(1));
        }
    }

    void RotateObject(Touch touch)
    {
        float rotationY = touch.deltaPosition.x * rotationSpeed;
        transform.Rotate(0, -rotationY, 0, Space.World);
    }

    void ScaleObject(Touch touch0, Touch touch1)
    {
        Vector2 touch0PrevPos = touch0.position - touch0.deltaPosition;
        Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;

        float prevMagnitude = (touch0PrevPos - touch1PrevPos).magnitude;
        float currentMagnitude = (touch0.position - touch1.position).magnitude;

        float difference = currentMagnitude - prevMagnitude;

        float scaleFactor = 1 + difference * scaleSpeed;

        transform.localScale = Vector3.ClampMagnitude(transform.localScale * scaleFactor, 3f);
    }
}


