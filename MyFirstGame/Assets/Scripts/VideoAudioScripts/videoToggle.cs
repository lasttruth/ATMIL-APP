using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class videoToggle : MonoBehaviour
{
    public GameObject active = null;
    public GameObject theOtherThing; //this will change to an array to iterate over to work with more object in the same group 
    public int counter = 0;
    public void toggleVideo()
    {
        //toggles video whenever the object is active or not
        
        if (active.activeInHierarchy == true && theOtherThing.activeInHierarchy == true){
            //check to if the video is active in the hierachy. if so set the other active object to false and show the video.
            Debug.Log("video is working now time to turn it off *discord noise* BA DOM!");
            theOtherThing.SetActive(false);
        }
        else if (active.activeInHierarchy == false && theOtherThing.activeInHierarchy == true)
        {
            //now if the video is not active we will still turn off the other objects but turn on the video
            theOtherThing.SetActive(false);
            active.SetActive(true);

        }      
        else
        {
            //default(when user first enter the screen) just turn on the video
            active.SetActive(true);
        }
       
    }
}
