using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
public void OnButtonPress()
    {
        //This loads the start scene
        SceneManager.LoadScene("StartScene");
    }
}
