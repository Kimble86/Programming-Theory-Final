using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cube object will change the title text only.
/// </summary>
public class CubeObject : Shape
{
    private string textToDisplay = "Cube was clicked!";

    // ENCAPSULATION
    public string TextToDisplay
    {
        get { return textToDisplay; }
        set { textToDisplay = value; }
    }

    public override void OnShapeClick()
    {
        ChangeText(textToDisplay);
    }
}
