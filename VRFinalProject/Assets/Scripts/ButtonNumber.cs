using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    public int buttonN;

    public CanvasManager manager;
    List<CanvasGroup> canvasList;

    private void Awake()
    {
        manager = GetComponentInParent<CanvasManager>();
        canvasList = manager.canvasList;
    }

    private void Start()
    {
        TurnOffAllCanvas();

        canvasList[0].interactable = true;
        canvasList[0].blocksRaycasts = true;
        canvasList[0].alpha = 1;
    }

    public void TurnOffAllCanvas()
    {
        foreach (CanvasGroup canvasGroup in canvasList)
        {
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.alpha = 0;
        }
    }

    public void TurnOnCanva()
    {
        canvasList[buttonN].interactable = true;
        canvasList[buttonN].blocksRaycasts = true;
        canvasList[buttonN].alpha = 1;
    }
}
