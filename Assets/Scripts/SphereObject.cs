using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sphere object will change the title text and disappear for 1 second
/// </summary>
public class SphereObject : Shape
{
    private string m_TitleText = "Sphere was clicked! Where did it go?";
    private float m_duration = 1.0f;

    public override void OnShapeClick()
    {
        ChangeText(m_TitleText);
        StartCoroutine(Disappear(m_duration));
    }

    IEnumerator Disappear(float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            this.gameObject.SetActive(false);
            elapsedTime += Time.deltaTime;
            yield return null;
            this.gameObject.SetActive(true);
        }
    }
}
