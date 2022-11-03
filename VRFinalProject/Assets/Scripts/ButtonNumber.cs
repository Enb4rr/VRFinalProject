using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    public int buttonN;

    CanvasManager manager;
    List<CanvasGroup> canvasList;

    private void Awake()
    {
        manager = FindObjectOfType<CanvasManager>();
        canvasList = manager.canvasList;
    }

    public void TurnOffAllCanvas()
    {
        foreach (CanvasGroup canvasGroup in canvasList)
        {
            canvasGroup.interactable = false;
            canvasGroup.alpha = Mathf.Lerp(1, 0, 0.2f);
        }
    }

    public void TurnOnCanva()
    {
        canvasList[buttonN].alpha = Mathf.Lerp(0, 1, 0.4f);
        canvasList[buttonN].interactable = true;
    }
}
