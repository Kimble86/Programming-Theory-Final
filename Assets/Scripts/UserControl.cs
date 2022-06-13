using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles the user input and clicks
/// </summary>
public class UserControl : MonoBehaviour
{
    public Camera GameCamera;

    private Shape selectedShape = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();

            if(selectedShape != null)
            {
                selectedShape.OnShapeClick();
            }
        }
    }

    private void HandleSelection()
    {
        var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //the collider could be children of the unit, so we make sure to check in the parent
            var shape = hit.collider.GetComponentInParent<Shape>();
            selectedShape = shape;
        }
    }
}
