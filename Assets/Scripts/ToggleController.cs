using UnityEngine;

public class ToggleController : MonoBehaviour
{
    // Reference to the GameObject to be toggled
    public GameObject targetObject;

    public void ToggleActiveState()
    {
        if (targetObject != null)
        {
            // Toggle the active state of the GameObject
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
