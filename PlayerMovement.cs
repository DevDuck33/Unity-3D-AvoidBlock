using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float SpeedForward = 250f;
    public float SpeedRotate = 400f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, SpeedForward * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-SpeedRotate * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(SpeedRotate * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
