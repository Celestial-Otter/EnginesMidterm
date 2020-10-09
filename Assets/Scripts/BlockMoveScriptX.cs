//Refernces: https://answers.unity.com/questions/690884/how-to-move-an-object-along-x-axis-between-two-poi.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoveScriptX : MonoBehaviour
{
    private bool forward = true;
    public float speed = 2.0f;
    public float startX = 0.0f;
    public float endX = 10.0f;

    void Update()
    {
        if (forward == true)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.right * speed * Time.deltaTime);

        if (transform.position.x >= endX)
        {
            forward = false;
        }

        if (transform.position.x <= startX)
        {
            forward = true;
        }
    }
}