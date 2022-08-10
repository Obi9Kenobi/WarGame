using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairaktarMove : MonoBehaviour
{   
    //flying speed properties
    [SerializeField] float Acceleration = 0.5f;
    [SerializeField] float MaxSpeed = 1f;
    [SerializeField] float MinSpeed = 0f;

    //rotating properties
    float RotatingSpeed = 50f;
    float MaxYRotationSpeed = 0.7f;
    float MinYRotationSpeed = -0.7f;
    float MaxXRotationSpeed = 0.7f;
    float MinXRotationSpeed = -0.7f;

    //just sturting value, not very useful
    float yAngle = 0f;
    float xAngle = 0f;
    float Speed = 0f;
    
    //rigidbody
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement();
        if (Speed > 0)
        {
            yRotation();
        }
        if (Speed > 0.1)
        {
            rb.useGravity = false;
            xRotation();
            zRotation();
        }
        if (Speed > 0.2)
        {
            rb.useGravity = false;
        }
        else
        {
            rb.useGravity = true;
        }
    }   


    void movement()
    {
        //moving forward
        float SpeedChange = Input.GetAxis("Vertical") * Time.deltaTime * Acceleration;
        Speed += SpeedChange;
        if (Speed < MinSpeed)
        {
            Speed = MinSpeed;
        }
        if (Speed > MaxSpeed)
        {
            Speed = MaxSpeed;
        }
        Debug.Log(Speed);
        transform.Translate(0, 0, Speed);
        //rb.velocity = new Vector3(0, 0, Speed);
        //rb.AddRelativeForce(0, 0, Speed);
    }

    void zRotation ()
    {
        //barrel-turning
        float zAngle = -Input.GetAxis("Horizontal") * Time.deltaTime * RotatingSpeed;
        transform.Rotate(0, 0, zAngle);
    }

    void xRotation ()
    {
        // Up-down Rotation
        float xAngleChange = -Input.GetAxis("Mouse Y") * Time.deltaTime * 10;
        xAngle += xAngleChange;
        if (xAngle < MinXRotationSpeed)
        {
            xAngle = MinXRotationSpeed;
        }
        if (xAngle > MaxXRotationSpeed)
        {
            xAngle = MaxXRotationSpeed;
        }
        transform.Rotate(xAngle, 0, 0);
    }

    void yRotation ()
    {
        // Left-right rotation
        float yAngleChange = Input.GetAxis("Mouse X") * Time.deltaTime * 10;
        yAngle += yAngleChange;
        if (yAngle < MinYRotationSpeed)
        {
            yAngle = MinYRotationSpeed;
        }
        if (yAngle > MaxYRotationSpeed)
        {
            yAngle = MaxYRotationSpeed;
        }
        transform.Rotate(0, yAngle, 0);
    }
    
}
