using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopView : MonoBehaviour
{
    public GameObject TopCam;
    public GameObject FrontCam;
    public int ThreeFourCam;


    void Update()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (ThreeFourCam == 1)
            {
                ThreeFourCam = 0;
            }
            else
            {
                ThreeFourCam += 1;
            }
            StartCoroutine(CamChange());
        }
    }

 

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (ThreeFourCam == 0)
        {
            TopCam.SetActive(true);
            FrontCam.SetActive(false);
        }
        if(ThreeFourCam == 1)
        {
            FrontCam.SetActive(true);
            TopCam.SetActive(false);
        }
    }
}