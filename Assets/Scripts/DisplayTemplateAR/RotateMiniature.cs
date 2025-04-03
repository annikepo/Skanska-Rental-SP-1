using UnityEngine;

public class RotateMiniature : MonoBehaviour
{
    public Transform miniatureObject;  // Assign this in the Inspector
    [SerializeField] float rotationSpeed = 90f;
    public void RotateLeft()
    {
        Debug.Log("Rotating Left");
        if (miniatureObject != null)
        {
            miniatureObject.eulerAngles += new Vector3(0, rotationSpeed, 0); // Directly changing eulerAngles
        }
    }

    public void RotateRight()
    {
        Debug.Log("Rotating Right");
        if (miniatureObject != null)
        {
            miniatureObject.eulerAngles += new Vector3(0, -rotationSpeed, 0);
        }
    }
}