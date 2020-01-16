using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToMove : MonoBehaviour
{

    public GameObject setPosition;
    
    //when object is clicked
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log("You clicked on the object " + hit.collider.name);
            this.transform.position = setPosition.transform.position;
        }
        
       
    }
}
