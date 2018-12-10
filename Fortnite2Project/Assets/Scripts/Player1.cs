using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public float moveAmount = 0.5f;
    public Rigidbody rb;
    public float forceAmount;
    public float jumpAmount;
    public int MaxJumps = 2;
    int jumpCount = 0;

    // Use this for initialization
    void Start()
    {
        jumpCount = MaxJumps;

    }

    // Update is called once per frame
    void Update()
    {

        //transformMove();
        //RigidbodyMove(); 
        RigidBodyForce();

    }


    void transformMove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(moveAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(moveAmount, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, moveAmount, 0);
        }

        /*if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0, moveAmount, 0);
        }
        */
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(0, 1, 0);
        }

    }


    void RigidBodyForce()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //rb.AddForce(new Vector3(0, jumpAmount, 0), ForceMode.VelocityChange);
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount, rb.velocity.z);
            jumpCount += 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(forceAmount, 0, 0));
            transform.rotation = Quaternion.AngleAxis(18, Vector3.down);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-forceAmount, 0, 0));
            transform.rotation = Quaternion.AngleAxis(18, Vector3.up);
        }
    }

    void RigidbodyMove()
    {


        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + new Vector3(moveAmount, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position - new Vector3(moveAmount, 0, 0));
        }

    }

}
