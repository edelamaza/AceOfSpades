using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour {

    public Text score1;
    public Text win;

    public Rigidbody rb1;
    public Rigidbody rb2;

    public int currentScore1;
    public int maxScore;


    public void Score()
    {
        currentScore1 += 1;
        score1.text = currentScore1 + "";

        if (currentScore1 == maxScore)
        {
            win.text = "Player 1 WINS!";
            rb1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            rb2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        }
    }


     // Use this for initialization
    void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
