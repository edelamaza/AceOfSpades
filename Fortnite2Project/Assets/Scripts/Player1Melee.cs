using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Melee : MonoBehaviour {
    public float i;
    public float attackCoolDown;
    private float timeLastAttack;
    // Use this for initialization
    void Start () {
        i = 0;
        timeLastAttack = -100000;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(i);
	}
    private void OnTriggerEnter(Collider col)
    {
        if (Time.time - timeLastAttack > attackCoolDown)
        {
            if (col.gameObject.name == "Player2Head")
            {
                timeLastAttack = Time.time;
                i++;


            }
        }
    }
}
