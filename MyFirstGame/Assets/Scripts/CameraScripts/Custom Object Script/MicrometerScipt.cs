using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrometerScipt : MonoBehaviour
{
    public float rotSpeed = 1f;
    public GameObject Thimble;
    public GameObject Spindle;
    private bool isDragging = false;


    private void OnMouseDrag()
    {
        

        
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            Thimble.transform.RotateAround(Vector3.right, -rotY);

            if (Input.GetAxis("Mouse Y") < 0)
            {
                Spindle.transform.Translate(Vector3.up  * rotSpeed * Time.deltaTime);

            }
            if (Input.GetAxis("Mouse Y") > 0)
            {
                Spindle.transform.Translate(Vector3.down * rotSpeed * Time.deltaTime);
            }

        }
       
       
        

    

    private void OnCollisionEnter(Collision collision)
    {
        Thimble.transform.Rotate(Vector3.zero);
        Spindle.transform.Translate(Vector3.zero);
        Debug.Log("captian we hit something");
    }

}




