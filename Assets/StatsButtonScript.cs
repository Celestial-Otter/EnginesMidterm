﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsButtonScript : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene("StatsScene");
    }
}