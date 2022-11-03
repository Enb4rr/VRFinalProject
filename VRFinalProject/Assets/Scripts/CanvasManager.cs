using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    [SerializeField] public Canvas initialCanvas;
    [SerializeField] public List<CanvasGroup> canvasList = new List<CanvasGroup>();
    [SerializeField] public List<Button> buttonList = new List<Button>();

    private void Awake()
    {
        initialCanvas = GetComponent<Canvas>();
    }

    public void DeactivateCanvas()
    {
        initialCanvas.gameObject.SetActive(false);
    }


}
