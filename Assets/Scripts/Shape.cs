using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public TMPro.TMP_Text TitleText;

    [SerializeField]
    private string whenClicked = "I am a little shape and I was clicked";

    public virtual void OnShapeClick()
    {
        ChangeText(whenClicked);
    }

    public virtual void ChangeText(string text)
    {
        TitleText.text = text;
    }

}
