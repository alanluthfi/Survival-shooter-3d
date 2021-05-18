using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUp : MonoBehaviour
{
    PlayerHealth playerHealth;
    GameObject player;
    public Slider healthSlider;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    //Callback jika ada suatu object masuk kedalam trigger
    void OnTriggerEnter(Collider other)
    {
        //Set player dalam range
        if (other.gameObject == player)
        {
            playerHealth.currentHealth += 30;
            healthSlider.value = playerHealth.currentHealth;
        }
    }

}
