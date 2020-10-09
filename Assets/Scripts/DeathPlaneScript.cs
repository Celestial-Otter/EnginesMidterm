using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneScript : MonoBehaviour
{
    public GameObject Player;
    void OnTriggerEnter(Collider other)
    {
    GameObject CurCheckpoint = GameObject.Find("Checkpoint " + CheckpointBehaviour.checkPoints);
        Player.transform.position = CurCheckpoint.transform.position;
        Debug.Log(transform.position);
        Debug.Log(CurCheckpoint.transform.position);
    }
}
