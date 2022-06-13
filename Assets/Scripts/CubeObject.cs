using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cube object will change the title text only.
/// </summary>
public class CubeObject : Shape
{
    private string m_TitleText = "Cube was clicked!";

    public override void OnShapeClick()
    {
        ChangeText(m_TitleText);
    }

    private void Disappear()
    {
        // Shape can disappear
    }
}
