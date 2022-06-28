using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BairaktarMove : MonoBehaviour
{
    [SerializeField] float SpeedChange = 0.5f;
    [SerializeField] float RotatingSpeed = 500f;
    float Speed = 0;
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
        SpeedChange = Input.GetAxis("Vertocal") * Time.deltaTime * 1;
        Speed += SpeedChange;
        float UD = -Input.GetAxis("Mouse Y") * Time.deltaTime * 150;
        float LR = Input.GetAxis("Mouse X") * Time.deltaTime * 150;
        transform.Translate(0, 0, Speed);
        transform.Rotate(UD, LR, Rotate);
    }
}