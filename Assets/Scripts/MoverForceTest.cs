using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverForceTest : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        rb.velocity = new Vector3(0, 0, 10);
    }
}

