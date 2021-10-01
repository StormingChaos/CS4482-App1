using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthOrbScript : MonoBehaviour
{
    //reference to player
    GameObject player;
    //reference to playerhealth
    PlayerHealth playerHealth;
    //sound clip for picking up health
    public AudioClip healthClip;
    //default health added
    public int healthCount = 10;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range to pick up the health
            //only pick up health if player is not dead and not max health
            if (playerHealth.currentHealth > 0 && playerHealth.currentHealth < playerHealth.startingHealth)
            {
                PickUp();
            }
        }
    }

    void PickUp()
    {
        //play sound clip
        AudioSource.PlayClipAtPoint(healthClip, transform.position);
        //add health to player
        playerHealth.currentHealth += healthCount;
        //if adding health put the player at over max health, set it to max
        if (playerHealth.currentHealth > playerHealth.startingHealth)
        {
            playerHealth.currentHealth = playerHealth.startingHealth;
        }
        //update health slider
        playerHealth.updateHealthSlider();
        //destroy health orb
        Destroy(gameObject);
    }
}
