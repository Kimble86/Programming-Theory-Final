using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sphere object will change the title text and disappear for 1 second
/// </summary>
public class SphereObject : Shape
{
    private string m_TitleText = "Sphere was clicked! Where did it go?";
    private string m_TitleTextAppear = "Just kidding, here I am!";
    private float m_duration = 2.0f;

    // POLYMORPHISM
    public override void OnShapeClick()
    {
        // ABSTRACTION
        ChangeText(m_TitleText);
        StartCoroutine(Disappear(m_duration));
    }

    IEnumerator Disappear(float duration)
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(duration);
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        ChangeText(m_TitleTextAppear);
    }
}
