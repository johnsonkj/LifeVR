using UnityEngine;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour
{
    public ScrollRect scrollRect;
   // public Button leftButton;
   // public Button rightButton;
    public RectTransform content;
    public float itemWidth = 200f; // Adjust based on your button width
    private int currentIndex = 0;
    private int totalItems;

    void Start()
    {
        totalItems = content.childCount;

       // leftButton.onClick.AddListener(() => MoveLeft());
        //rightButton.onClick.AddListener(() => MoveRight());

        //UpdateButtons();
    }

    public void MoveLeft()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            ScrollToIndex(currentIndex);
        }
    }

    public void MoveRight()
    {
        if (currentIndex < totalItems - 1)
        {
            currentIndex++;
            ScrollToIndex(currentIndex);
        }
    }

    void ScrollToIndex(int index)
    {
        float targetX = index * itemWidth;
        float normalizedPosition = targetX / (content.rect.width - scrollRect.viewport.rect.width);
        scrollRect.horizontalNormalizedPosition = Mathf.Clamp01(normalizedPosition);

        //UpdateButtons();
    }

   /* void UpdateButtons()
    {
        leftButton.interactable = currentIndex > 0;
        rightButton.interactable = currentIndex < totalItems - 1;
    }*/
}
