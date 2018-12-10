using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount;
    public float jumpAmount;
    public int MaxJumps;
    int jumpCount = 0;
    void Start()
    {
        jumpCount = 0;

    }
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
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.I))
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
