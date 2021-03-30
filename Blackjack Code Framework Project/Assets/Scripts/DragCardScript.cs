using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCardScript : MonoBehaviour
{
    // Difference between mouse cursor position and game object position. 
    private Vector3 mOffset; 
    private float mouseZCoord; 

    void OnMouseDown() 
    {
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; 
        // Store offset value = card's world position - mouse's world position
        mOffset = gameObject.transform.position - GetMouseWorldPos(); 
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition; 

        //z position of the gameobject
        mousePoint.z = mouseZCoord; 

        return Camera.main.ScreenToWorldPoint(mousePoint); 
    }

    void OnMouseDrag() 
    {
        transform.position = GetMouseWorldPos() + mOffset; 
        transform.position = new Vector3(GetMouseWorldPos().x + mOffset.x, transform.position.y, GetMouseWorldPos().z + mOffset.z);
    }
}
