using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonManager : MonoBehaviour
{
    public void OnButtonPress()
    {
        //closes the application
        Application.Quit();
    }
}
