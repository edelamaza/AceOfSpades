using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Melee : MonoBehaviour {
    public float attackCoolDown;
    private float timeLastAttack;
    public Player2Health p2H;
    // Use this for initialization
    void Start () {
        timeLastAttack = -100000;
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnTriggerEnter(Collider col)
    {
        if (Time.time - timeLastAttack > attackCoolDown)
        {
            if (col.gameObject.name == "Player2Head")
            {
                timeLastAttack = Time.time;
                p2H.Hurt();


            }
        }
    }
}
