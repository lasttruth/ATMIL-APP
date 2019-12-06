using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class videoToggle : MonoBehaviour
{
    public GameObject active = null;
    public int counter = 0;
    public void toggleVideo()
    {
        //toggles video whenever the botton is pushed based on the counter
        counter++;
            if (counter % 2 == 1)
        {
            active.SetActive(true);
            
        } else
        {
            active.SetActive(false);
        }
    }
}
