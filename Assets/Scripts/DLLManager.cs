//References: https://www.codegrepper.com/code-examples/csharp/unity+how+to+change+text+in+script
//https://answers.unity.com/questions/699565/how-to-get-a-variable-value-from-another-scriptc.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

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


    //UNITY FUNCTIONS
    public void SaveTimeTest(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTimeTest(int index)
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

    public float LoadTotalTimeTest()
    {
        return GetTotalTime();
    }

    public void ResetLoggerTest()
    {
        ResetLogger();
    }




    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;

            SaveTimeTest(checkpointTime);
        }

        for (int i = 0; i < 5; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0+i))
            {
                Debug.Log(LoadTimeTest(i));
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(LoadTotalTimeTest());
        }
        
        //Timer UI object
        Text Timer = GameObject.Find("Canvas/Text").GetComponent<Text>();
        Timer.text = "Checkpoints: " + CheckpointBehaviour.checkPoints.ToString() + "/6"; 
    }
    public void OnDestroy()
    {
        ResetLoggerTest();
    }
}
