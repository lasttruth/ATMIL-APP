using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOnClick : MonoBehaviour
{
    public GameObject[] buttons;


    private void OnMouseDown()
    {
        buttons[0].SetActive(true);
        buttons[1].SetActive(true);
        buttons[2].SetActive(true);
    }
}
