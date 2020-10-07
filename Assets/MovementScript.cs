//References: https://answers.unity.com/questions/421117/how-do-you-make-a-game-object-into-a-controllable.html
            //https://docs.unity3d.com/ScriptReference/CharacterController.SimpleMove.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementScript : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotateSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //Rotation
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        //Move forwards and backwards
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}
