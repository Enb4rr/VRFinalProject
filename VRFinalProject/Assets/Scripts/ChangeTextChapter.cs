using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextChapter : MonoBehaviour
{

    [SerializeField] string chapterText;
    public Text displayText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeText()
    {
        displayText.text = chapterText;
    }

}
