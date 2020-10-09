using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject CurCheckpoint = GameObject.Find("Checkpoint " + CheckpointBehaviour.checkPoints);
        other.GetComponent<CharacterController>().enabled = false;
        other.transform.position = CurCheckpoint.transform.position + new Vector3(0, 5, 0);
        other.GetComponent<CharacterController>().enabled = true;
    }
}
