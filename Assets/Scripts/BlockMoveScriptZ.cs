using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoveScriptZ : MonoBehaviour
{
    private bool forward = true;
    public float speed = 2.0f;
    public float startZ = 0.0f;
    public float endZ = 10.0f;

    void Update()
    {
        if (forward == true)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.z >= endZ)
        {
            forward = false;
        }

        if (transform.position.z <= startZ)
        {
            forward = true;
        }
    }
}
