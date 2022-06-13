using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cylinder object will change the title text, and also it will change the text of cube object
/// </summary>
public class CylinderObject : Shape
{
    public CubeObject cube;
    private string m_TitleText = "Cylinder was clicked! I think cube doesn't like me...";

    // INHERITANCE
    public override void OnShapeClick()
    {
        ChangeText(m_TitleText);
        cube.TextToDisplay = "Why did you click Cylinder!!!";
    }
}
