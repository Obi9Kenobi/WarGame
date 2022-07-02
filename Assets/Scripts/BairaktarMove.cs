using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairaktarMove : MonoBehaviour
{
    float SpeedChange = 0;
    float SpeedChangeSpeed = 1;
    float RotatingSpeed = 50;
    float Speed = 0.5f;
    float MaxSpeed = 0.8f;
    float MinSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float R = -Input.GetAxis("Horizontal") * Time.deltaTime * RotatingSpeed;
        SpeedChange = Input.GetAxis("Vertical") * Time.deltaTime * SpeedChangeSpeed;
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
        float UD = -Input.GetAxis("Mouse Y") * Time.deltaTime * 150;
        float LR = Input.GetAxis("Mouse X") * Time.deltaTime * 150;

        //move
        transform.Translate(0, 0, Speed);
        transform.Rotate(UD, LR, R);
    }
}