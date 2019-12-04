using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichCamera : MonoBehaviour
{
    public GameObject FrontCamera = null;
    public GameObject SecondCamera = null;
    public int counter = 0;
    public void CamerSwitch()
    {
        //swtiching camera views based on what camera is placed into the editor
        counter++;
        if (counter % 2 == 1)
        {
            SecondCamera.SetActive(true);
            FrontCamera.SetActive(false);

        }
        else
        {
            FrontCamera.SetActive(true);
            SecondCamera.SetActive(false);
        }
    }
}
