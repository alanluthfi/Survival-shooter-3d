using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    PlayerMovement playerMovement;
    GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    //Callback jika ada suatu object masuk kedalam trigger
    void OnTriggerEnter(Collider other)
    {
        //Set player dalam range
        if (other.gameObject == player)
        {
            playerMovement.speed += 3f;
        }
    }
}
