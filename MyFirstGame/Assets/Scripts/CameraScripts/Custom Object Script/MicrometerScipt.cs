using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrometerScipt : MonoBehaviour
{
    public float rotSpeed = 1f;
    public float tranSpeed;
    public GameObject Thimble;
    public GameObject Spindle;
    private bool isDragging = false;


    private void OnMouseDrag()
    {


        MoveSpindle();
        MoveThimble();

        }
       
       
        

    

    private void OnCollisionEnter(Collision collision)
    {
        Thimble.transform.Rotate(Vector3.zero);
        Spindle.transform.Translate(Vector3.zero);
        Debug.Log("captian we hit something");
    }





    void MoveSpindle()
    {
        if (Input.GetAxis("Mouse Y") < 0)
        {
            Spindle.transform.Translate(Vector3.down * tranSpeed * Time.deltaTime);

            Thimble.transform.Translate(Vector3.right * tranSpeed * Time.deltaTime);

        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            Spindle.transform.Translate(Vector3.up * tranSpeed * Time.deltaTime);
            Thimble.transform.Translate(Vector3.left * tranSpeed * Time.deltaTime);
        }
    }

    void MoveThimble() {

        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        Thimble.transform.Rotate(Vector3.right, rotY);
        

    }
}




