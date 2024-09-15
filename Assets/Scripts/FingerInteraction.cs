using UnityEngine;
using UnityEngine.UI;

public class FingerInteraction : MonoBehaviour
{
    // Adjust the fade amount (set it to less than 1 to fade)
    public float fadeAmount = 0.5f;

    // Store the original color of the button image to restore later
    private Color originalColor;

    // OnTriggerEnter is called when the finger collider enters another collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object hit has a Button component
        Button button = other.GetComponent<Button>();
        if (button != null)
        {
            // Get the original color of the button's image
            originalColor = button.image.color;

            // Fade the button by reducing the alpha (or change the color as needed)
            Color fadedColor = originalColor;
            fadedColor.a *= fadeAmount;  // Adjust alpha for fading
            button.image.color = fadedColor;

            // Call the button's onClick function
            button.onClick.Invoke();
        }
    }

    // OnTriggerExit is called when the finger collider exits another collider
    private void OnTriggerExit(Collider other)
    {
        // Check if the object hit has a Button component
        Button button = other.GetComponent<Button>();
        if (button != null)
        {
            // Restore the button's original color when the finger leaves the button
            button.image.color = originalColor;
        }
    }
}
