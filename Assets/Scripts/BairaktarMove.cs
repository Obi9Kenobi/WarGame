using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairaktarMove : MonoBehaviour
{
    [SerializeField] float FlightSpeed = 0.5f;
    [SerializeField] float RotatingSpeed = 500f;
    bool Rotated = false;
    float R = 0;
    float Rotate = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate = -Input.GetAxis("Horizontal") * Time.deltaTime * RotatingSpeed;
        R += Rotate;
        Debug.Log(R);
        float UD = -Input.GetAxis("Mouse Y") * Time.deltaTime * 300;
        float LR = Input.GetAxis("Mouse X") * Time.deltaTime * 300;
        transform.Translate(0, 0, FlightSpeed);
        transform.Rotate(UD, LR, Rotate);
/*        if (R < 2 & R > -2)
        {
            Rotated = false;
        }
        else
        {
            Rotated = true;
        }
       if (Rotated)
       {
            if (R != 0)
            {
                LR -= 0.01f;
                transform.Rotate(0, 0, LR);
            }
       }*/
    }
}