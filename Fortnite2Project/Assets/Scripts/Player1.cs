using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount;
    public float jumpAmount;
    public int MaxJumps;
    int jumpCount = 0;

    // Use this for initialization
    void Start()
    {
        jumpCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        RigidBodyForce();
        if (jumpCount < MaxJumps)
        {
            Jump();
        }
    }

    void RigidBodyForce()
    {
       
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
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount, rb.velocity.z);
            jumpCount += 1;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane")
        {
            jumpCount = 0;
        }
    }
}