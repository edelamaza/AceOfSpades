using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Health : MonoBehaviour
{
    public GameObject player2;

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
            Debug.Log("Oh no. I died. You have killed me.");
        }
        if (currentHealth == 0)
        {
            Destroy(player2);

        }

        //update health bar UI
        float percent = currentHealth / maxHealth;
        HealthBar.fillAmount = percent;
    }
}
