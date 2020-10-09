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
        //Checks to see if checkpoint has been triggered already
        if (isTriggered == false)
        {
            //increment checkPoints variable for the deathplane
            checkPoints++;
            //Change triggered value to true
            isTriggered = true;
            //change colour of checkpoint
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log(checkPoints);
        }
        else
        {

        }

    }
}
