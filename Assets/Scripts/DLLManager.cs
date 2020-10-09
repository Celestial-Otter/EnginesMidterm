//References: https://www.codegrepper.com/code-examples/csharp/unity+how+to+change+text+in+script
//https://answers.unity.com/questions/699565/how-to-get-a-variable-value-from-another-scriptc.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

public class DLLManager : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLL";


    //METHODS
    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    //SETTERS
    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    //GETTERS
    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();
    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int index);
    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;
    int currentCheck = 0;


    //UNITY FUNCTIONS
    public void SaveCheckTime(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadCheckTime(int index)
    {
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(index);
        }
    }

    public float LoadTotalTime()
    {
        return GetTotalTime();
    }

    public void ResetLog()
    {
        ResetLogger();
    }




    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
        int currentCheck = CheckpointBehaviour.checkPoints;

    }

    // Update is called once per frame
    void Update()
    {
        //Check to see if player has tripped a new checkpoint
        if (currentCheck != CheckpointBehaviour.checkPoints)
        {
            //record checkpoint time
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;

            SaveCheckTime(checkpointTime);
            currentCheck = CheckpointBehaviour.checkPoints;

            //write checkpoint time to stats screen
            Text Checkp = GameObject.Find("Canvas/Checkpoint" + currentCheck).GetComponent<Text>();
            Checkp.text = "Checkpoint " + CheckpointBehaviour.checkPoints.ToString() + ": " + LoadTotalTime().ToString();

            StatsSaverScript.checkPointTimes[currentCheck] = checkpointTime;

            //check if maze is completed
            if (currentCheck == 6)
            {
                StatsSaverScript.totalRunTime = LoadTotalTime();
                SceneManager.LoadScene("StatsScene");
            }
        }
/*
        for (int i = 0; i < 6; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0+i))
            {
                Debug.Log(LoadCheckTime(i));
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(LoadTotalTime());
        }
*/
        
        //Timer UI object
        Text Timer = GameObject.Find("Canvas/CheckPointCounter").GetComponent<Text>();
        Timer.text = "Checkpoints: " + CheckpointBehaviour.checkPoints.ToString() + "/6";
    }
    public void OnDestroy()
    {
        ResetLog();
    }
}
