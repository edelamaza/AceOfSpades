using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Health : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public Player2Health p2H;

    public Player2Score ScoreTrack;


    [Header("Object References")]
    public Image HealthBar;
    [Header("Health Stats")]
    public float maxHealth;
    public float damagePerHit;

    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void Hurt()
    {
        //update health stats
        currentHealth -= damagePerHit;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            //Debug.Log("Oh no. I died. You have killed me.");
        }
        if (currentHealth == 0)
        {
            ScoreTrack.Score();
            player1.transform.position = new Vector3(-7.3f, 10, -11.33f);
            player2.transform.position = new Vector3(6.43f, 10, -11.33f);
            currentHealth = maxHealth;
            p2H.resetHealth();


}


//update health bar UI
float percent = currentHealth / maxHealth;
        HealthBar.fillAmount = percent;
    }
    public void resetHealth()
    {
        currentHealth = maxHealth;
        HealthBar.fillAmount = 1;
    }
}
