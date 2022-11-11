using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextChapter : MonoBehaviour
{

    [SerializeField] string chapterText;
    public TMP_Text displayText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        displayText.text = chapterText;
    }

}
