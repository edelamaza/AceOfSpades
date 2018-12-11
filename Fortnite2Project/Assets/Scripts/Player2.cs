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
    public float dashAmount;
    public float dashCoolDown;

    private float timeLastDash;
    void Start()
    {
        jumpCount = 0;
        timeLastDash = -1000000;

    }
    void Update()
    {
        RigidBodyForce();
        if (jumpCount < MaxJumps)
        {
            Jump();
        }
        dash();

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
        if (col.gameObject.name == "Floor" || col.gameObject.name == "Platform1 Right" || col.gameObject.name == "Platform1 Left" || col.gameObject.name == "Platform2")
        {
            jumpCount = 0;
        }
    }
    void dash()
    {

        if (Time.time - timeLastDash > dashCoolDown)
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                rb.AddForce(new Vector3(dashAmount, 0, 0));
                transform.rotation = Quaternion.AngleAxis(18, Vector3.down);
                timeLastDash = Time.time;

            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                rb.AddForce(new Vector3(-dashAmount, 0, 0));
                transform.rotation = Quaternion.AngleAxis(18, Vector3.down);
                timeLastDash = Time.time;

            }
        }
    }

}
