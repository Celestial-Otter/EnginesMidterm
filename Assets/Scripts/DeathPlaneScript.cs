using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //This Sets the active gameObject to the current checkpoint by taking a value from CheckpointBehaviour
        GameObject CurCheckpoint = GameObject.Find("Checkpoint " + CheckpointBehaviour.checkPoints);
        //Disables The character controller so transformations can be applied
        other.GetComponent<CharacterController>().enabled = false;
        //Move the collided object to the position of the checkpoint
        other.transform.position = CurCheckpoint.transform.position + new Vector3(0, 5, 0);
        //Reenable the character controller
        other.GetComponent<CharacterController>().enabled = true;
    }
}
