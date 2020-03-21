using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject selectedStates;

    //Menu States
    public enum MenuStates
    {
        Main,
        Profile,
        Lecture,
        WorkShop,
        Library,
        TestCenter,
        MakeUps
    };
    public MenuStates currentState;

    //Menu panel Objects
    public GameObject mainMenu;
    public GameObject Profile;
    public GameObject Lecture;
    public GameObject WorkShop;
    public GameObject Library;
    public GameObject TestCenter;
    public GameObject MakeUps;


    //when script first starts
    private void Awake()
    {
        // Alway set first menu
        currentState = MenuStates.Main;
        
    }

    private void Update()
    {
        if(gameObject == true)
        {
            selectedStates = gameObject;
        }

        //Checks current menu states

        switch (currentState)
        {
            case MenuStates.Main:
                Instantiate(mainMenu);
             //set active gameObject for main Menu
            break;

            case MenuStates.Profile:
                //set active gameObject
                break;

            case MenuStates.Lecture:
                //set active gameObject
                break;

            case MenuStates.Library:
                //set active gameObject
                break;

            case MenuStates.WorkShop:
                //set active gameObject
                break;

            case MenuStates.TestCenter:
                //set active gameObject
                break;

            case MenuStates.MakeUps:
                //set active gameObject
                break;


        }
    }




    // when the profile button is pressed
    public void OnProfile()
    {
        Debug.Log("You Pressed Profile smh");
    }

    // when the lecture button is pressed
    public void OnLecture()
    {
        Debug.Log("It time to get Schooled kid");
    }

    public void OnWorkShop()
    {
        Debug.Log("Remeber Shop class? No just me...");
    }

    public void OnLibrary()
    {

        Debug.Log("Yo remember that one chick from the Library I forget her name...");
    }

    public void OnTestCenter()
    {
        Debug.Log("do you remeber what you did? Cause I forget honsetly I need you to inform me");
    }

    public void OnMakeUps()
    {
        Debug.Log("you wanna pass? First you gotta pork Ms.Piggy");
    }

}

