using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrometerScipt : MonoBehaviour
{
    public float rotSpeed = 200;
    public GameObject Thimble;
    public GameObject Spindle;



    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        Thimble.transform.Rotate(Vector3.right, -rotY);

        if (Input.GetAxis("Mouse Y") < 0)
        {
            Spindle.transform.Translate(Vector3.up * Time.deltaTime);

        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            Spindle.transform.Translate(Vector3.down* Time.deltaTime);
        }
    }
}


   
