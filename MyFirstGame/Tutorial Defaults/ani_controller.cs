using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani_controller : MonoBehaviour
{

    public Animator anim;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void toggleMenu()
    {
        counter++;
        if (counter % 2 == 1)
        {
            //menu out
            anim.Play("Sub_menu");

        }
        else
        {
            //menu out
            anim.Play("Sub_menu 0");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("m"))
        {
            //menu out
            anim.Play("Sub_menu");
        }
        
    }

    
}
