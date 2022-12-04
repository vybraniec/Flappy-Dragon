using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 10f;
    public float jumpForce = 10f;
    public float UPPERBORDER = 15f;
    public float LOWERBORDER = -15f;
    bool jump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(forwardForce, rb.velocity.y, rb.velocity.z);
        if (jump)
        {
            rb.velocity = Vector3.up * jumpForce;
            jump = false;
        }
        if(transform.position.y > UPPERBORDER)
        {
            transform.position = new Vector3(transform.position.x, UPPERBORDER, transform.position.z);
        }
        else if (transform.position.y < LOWERBORDER)
        {
            transform.position = new Vector3(transform.position.x, LOWERBORDER, transform.position.z);
        }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }
}