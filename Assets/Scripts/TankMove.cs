using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Rotate = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * 5;
        float Move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0, 0, Move);
        transform.Rotate(0, Rotate, 0);
    }
}