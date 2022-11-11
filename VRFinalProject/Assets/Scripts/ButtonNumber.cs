using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNumber : MonoBehaviour
{
    public int buttonN;

    CanvasManager manager;
    List<CanvasGroup> canvasList;

    public GameObject canvasContainer;

    private void Awake()
    {
        manager = canvasContainer.GetComponent<CanvasManager>();
        canvasList = manager.canvasList;
    }

    public void TurnOffAllCanvas()
    {
        Debug.Log("Turning Off Canvas");
        foreach (CanvasGroup canvasGroup in canvasList)
        {
            canvasGroup.interactable = false;
            canvasGroup.alpha = Mathf.Lerp(1, 0, 0.2f);
        }
    }

    public void TurnOnCanva()
    {
        Debug.Log("Turning On Canvas");
        canvasList[buttonN].alpha = Mathf.Lerp(0, 1, 0.4f);
        canvasList[buttonN].interactable = true;
    }
}
