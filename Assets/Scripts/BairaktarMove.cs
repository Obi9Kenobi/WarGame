using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairaktarMove : MonoBehaviour
{
    float SpeedChangeSpeed = 1;
    float RotatingSpeed = 50;
    float Speed = 0.5f;
    float yAngle = 0f;
    float xAngle = 0f;
    float MaxSpeed = 0.8f;
    float MinSpeed = 0.2f;
    float MaxYRotationSpeed = 0.7f;
    float MinYRotationSpeed = -0.7f;
    float MaxXRotationSpeed = 0.7f;
    float MinXRotationSpeed = -0.7f;


    //starting constants
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zAngle = -Input.GetAxis("Horizontal") * Time.deltaTime * RotatingSpeed;
        float SpeedChange = Input.GetAxis("Vertical") * Time.deltaTime * SpeedChangeSpeed;
        Speed += SpeedChange;
        if (Speed < MinSpeed)
        {
            Speed = MinSpeed;
        }
        if (Speed > MaxSpeed)
        {
            Speed = MaxSpeed;
        }
        //Debug.Log(Speed);

        // X Rotation
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
        // Y axis rotation
        float yAngleChange = Input.GetAxis("Mouse X") * Time.deltaTime * 10;
        yAngle += yAngleChange;
        if(yAngle < MinYRotationSpeed)
        {
            yAngle = MinYRotationSpeed;
        }
        if (yAngle > MaxYRotationSpeed)
        {
            yAngle = MaxYRotationSpeed;
        }

        Debug.Log(yAngleChange);
        //Translate and Rotate
        transform.Translate(0, 0, Speed);
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
