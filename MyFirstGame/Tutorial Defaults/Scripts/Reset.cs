using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject[] defaultPos;
    public GameObject[] assembleparts;


    public void Default()
    {
        assembleparts[0].transform.position = defaultPos[0].transform.position;
        assembleparts[1].transform.position = defaultPos[1].transform.position;
    }
}
