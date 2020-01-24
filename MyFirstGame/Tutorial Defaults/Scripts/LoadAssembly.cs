using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadAssembly : MonoBehaviour
{
    public void SwitchToAssembly()
    {
        SceneManager.LoadScene("Object Assembly");
    }
}
