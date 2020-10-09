using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatsSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Get the TotalTime component in the Stats Section and write total time to it
        Text TotalTime = GameObject.Find("Stats/TotalTime").GetComponent<Text>();
        TotalTime.text = "Total Time: " + StatsSaverScript.totalRunTime.ToString();

        //loop through the checkpoint values and write values to them
        for (int i = 1; i < 7; i++)
        {
            Text CheckpointStuff = GameObject.Find("Stats/C" + i).GetComponent<Text>();
            CheckpointStuff.text = "Checkpoint " + i + ": " + StatsSaverScript.checkPointTimes[i].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
