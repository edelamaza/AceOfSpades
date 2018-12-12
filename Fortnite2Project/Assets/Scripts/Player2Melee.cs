using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Melee : MonoBehaviour
{
    public float attackCoolDown;
    private float timeLastAttack;

    public Player1Health p1H;

    // Use this for initialization
    void Start()
    {
        timeLastAttack = -100000;

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(i);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (Time.time - timeLastAttack > attackCoolDown)
        {
            if (col.gameObject.name == "Player1Head")
            {

                timeLastAttack = Time.time;
                p1H.Hurt();
            }
        }
    }
}
