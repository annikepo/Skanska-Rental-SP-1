using UnityEngine;

public class ProductLockPlacement : MonoBehaviour
{
    private bool isLocked = false;

    public void ToggleLock()
    {
        isLocked = !isLocked;
    }

    public bool IsLocked()
    {
        return isLocked;
    }
}

