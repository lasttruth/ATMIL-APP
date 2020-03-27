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
            selectedStates = GameObject.FindGameObjectWithTag("MenuState");
        }

        //Checks current menu states
        if(currentState == MenuStates.Profile)
        {
           
           
            selectedStates = GameObject.FindGameObjectWithTag("MenuState");
        }
        else if(currentState == MenuStates.Main)
        {

            
            selectedStates = GameObject.FindGameObjectWithTag("MenuState");
            

        }
        
    }




    // when the profile button is pressed
    public void OnProfile()
    {
       
        
            Debug.Log("You Pressed Profile smh");
            GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(false);
            currentState = MenuStates.Profile;
            GameObject go = Instantiate(Profile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            GameObject menu = GameObject.Find("Canvas");
            go.transform.SetParent(menu.transform, false);
        
       
    }

    // when the lecture button is pressed
    public void OnLecture()
    {
        currentState = MenuStates.Lecture;
        Debug.Log("It time to get Schooled kid");
        
    }

    public void OnWorkShop()
    {
        Debug.Log("Remeber Shop class? No just me...");
        currentState = MenuStates.WorkShop;
    }

    public void OnLibrary()
    {

        Debug.Log("Yo remember that one chick from the Library I forget her name...");
        currentState = MenuStates.Library;
    }

    public void OnTestCenter()
    {
        Debug.Log("do you remeber what you did? Cause I forget honsetly I need you to inform me");
        currentState = MenuStates.TestCenter;
    }

    public void OnMakeUps()
    {
        Debug.Log("you wanna pass? First you gotta pork Ms.Piggy");
        currentState = MenuStates.MakeUps;
    }

    public void OnHome()
    {
        Debug.Log("Ight Immma head out");
        if (!mainMenu.activeInHierarchy && currentState != MenuStates.Main)
        {
            GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(true);
            Destroy(selectedStates);
            currentState = MenuStates.Main;
            

        }
       
    }
}

