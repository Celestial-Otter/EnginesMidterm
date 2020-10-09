using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviour : MonoBehaviour
{
    public void OnButtonPress()
    {
        //loads the play scene
        SceneManager.LoadScene("PlayScene");
    }
}
