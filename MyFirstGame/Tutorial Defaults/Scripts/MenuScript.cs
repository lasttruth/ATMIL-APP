using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject selectedStates;

    //Menu States
    public enum MenuStates
    {
        Main,
        Profile,
        Lectures,
        WorkShop,
        Library,
        TestCenter,
        MakeUps
    };

    public MenuStates currentState;

    //Menu panel Objects
    public GameObject mainMenu;
    public GameObject Profile;
    public GameObject lecture;
    public GameObject WorkShop;
    public GameObject Library;
    public GameObject TestCenter;
    public GameObject MakeUps;

    //private objects**(might change this later)
    private GameObject ContainerOff;
    private GameObject ContainerOn;

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
        else if (currentState == MenuStates.Lectures)
        {
            selectedStates = GameObject.FindGameObjectWithTag("MenuState");

        }
        else if(currentState == MenuStates.Main)
        {

            
            selectedStates = GameObject.FindGameObjectWithTag("MenuState");
            

        }
        
    }




    //Main Menu Buttons
    public void OnProfile()
    {
       
        
        Debug.Log("You Pressed Profile smh");
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(false);
        currentState = MenuStates.Profile;
        GameObject go = Instantiate(Profile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject menu = GameObject.Find("Canvas");
        go.transform.SetParent(menu.transform, false);
        
       
    }

    public void OnLecture()
    {
        currentState = MenuStates.Lectures;
        Debug.Log("It time to get Schooled kid");
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(false);
        GameObject go = Instantiate(lecture, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject menu = GameObject.Find("Canvas");
        go.transform.SetParent(menu.transform, false);

    }

    public void OnWorkShop()
    {
        Debug.Log("Remeber Shop class? No just me...");
        currentState = MenuStates.WorkShop;
        GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(false);
        GameObject go = Instantiate(WorkShop, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        GameObject menu = GameObject.Find("Canvas");
        go.transform.SetParent(menu.transform, false);
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


    //Navbar Buttons
    public void OnHome()
    {
        Debug.Log("Ight Immma head out");
        if (!mainMenu.activeInHierarchy && currentState != MenuStates.Main)
        {
            GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(true);
            Destroy(selectedStates);
            currentState = MenuStates.Main;
            

        } else if (!mainMenu.activeInHierarchy)
        {
            GameObject.FindGameObjectWithTag("Canvas").transform.GetChild(0).gameObject.SetActive(true);
            currentState = MenuStates.Main;
        }
       
    }

    //WorkShopButtons
    
    public void OnMeasuring()
    {
        ContainerOff = GameObject.Find("Workshop Containter");
        ContainerOn = GameObject.FindGameObjectWithTag("MenuState");


        if (ContainerOff.activeInHierarchy)
        {
            ContainerOn.transform.GetChild(1).gameObject.SetActive(true);
            ContainerOff.transform.gameObject.SetActive(false);
        }
    }




    //Inside Measuring Container
    public void OnMicrometer()
    {
        SceneManager.LoadScene("micrometer");
    }
}

