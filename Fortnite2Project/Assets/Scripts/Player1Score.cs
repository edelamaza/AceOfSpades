using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour {

    public Text score1;

    public int currentScore1;


    public void Score()
    {
        currentScore1 += 1;
        score1.text = currentScore1 + "";
    }


     // Use this for initialization
    void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
