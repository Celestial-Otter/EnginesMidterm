using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CheckpointBehaviour : MonoBehaviour
{
    public static int checkPoints = 0;
    public bool isTriggered = false;
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (isTriggered == false)
        {
            checkPoints++;
            isTriggered = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log(checkPoints);
        }
        else
        {

        }

    }
}
