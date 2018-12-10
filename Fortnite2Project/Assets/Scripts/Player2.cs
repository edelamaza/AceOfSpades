using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float moveAmount = 0.5f;
    public Rigidbody rb;
    public float forceAmount = 20.0f;
    public float jumpAmount = 10.0f;

    // Use this for initialization
    void Start()
    {

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
        if (Input.GetKey(KeyCode.L))
        {
            transform.position = transform.position + new Vector3(moveAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.position = transform.position - new Vector3(moveAmount, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.position = transform.position + new Vector3(0, moveAmount, 0);
        }

        /*if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0, moveAmount, 0);
        }
        */
        /*if (Input.GetKey(KeyCode.U))
        {
            transform.position = new Vector3(0, 1, 0);
        }
        */
    }


    void RigidBodyForce()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //rb.AddForce(new Vector3(0, jumpAmount, 0), ForceMode.VelocityChange);
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(new Vector3(forceAmount, 0, 0));
            transform.rotation = Quaternion.AngleAxis(18, Vector3.down);
         
        }

        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(new Vector3(-forceAmount, 0, 0));
            transform.rotation = Quaternion.AngleAxis(18, Vector3.up);
        }
    }

    void RigidbodyMove()
    {


        if (Input.GetKey(KeyCode.L))
        {
            rb.MovePosition(transform.position + new Vector3(moveAmount, 0, 0));
        }

        if (Input.GetKey(KeyCode.J))
        {
            rb.MovePosition(transform.position - new Vector3(moveAmount, 0, 0));
        }

    }

}
