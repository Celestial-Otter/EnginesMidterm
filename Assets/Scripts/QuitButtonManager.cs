using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonManager : MonoBehaviour
{
    public void OnButtonPress()
    {
        Application.Quit();
    }
}
