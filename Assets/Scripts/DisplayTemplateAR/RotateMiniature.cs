using UnityEngine;

public class RotateMiniature : MonoBehaviour
{
    public float rotationSpeed = 90f; // Faster rotation for holding
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    void Update()
    {
        if (isRotatingLeft)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
        if (isRotatingRight)
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime, Space.World);
        }
    }

    public void StartRotatingLeft()
    {
        isRotatingLeft = true;
    }

    public void StopRotatingLeft()
    {
        isRotatingLeft = false;
    }

    public void StartRotatingRight()
    {
        isRotatingRight = true;
    }

    public void StopRotatingRight()
    {
        isRotatingRight = false;
    }
}