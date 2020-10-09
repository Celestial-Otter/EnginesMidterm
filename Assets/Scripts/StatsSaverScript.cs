using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSaverScript : MonoBehaviour
{
    public static float[] checkPointTimes = new float[7] { 0, 0, 0, 0, 0, 0, 0 };
    public static float totalRunTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
