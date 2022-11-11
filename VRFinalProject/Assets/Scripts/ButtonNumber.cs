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

        canvasList[0].alpha = Mathf.Lerp(0, 1, 1);
    }

    public void TurnOffAllCanvas()
    {
        Debug.Log("Turning Off Canvas");
        foreach (CanvasGroup canvasGroup in canvasList)
        {
            canvasGroup.interactable = false;
            canvasGroup.alpha = Mathf.Lerp(1, 0, 1);
        }
    }

    public void TurnOnCanva()
    {
        Debug.Log("Turning On Canvas");
        canvasList[buttonN].alpha = Mathf.Lerp(0, 1, 1);
        canvasList[buttonN].interactable = true;
    }
}
