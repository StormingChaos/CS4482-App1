using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       // Reference to the player's health.
    public float restartDelay = 5f;         // Time to wait before restarting the level

    Animator anim;                          // Reference to the animator component.
    float restartTimer;                     // Timer to count up to restarting the level

    // Start is called before the first frame update
    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");
            // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay)
            {
                //restart the level
                playerHealth.RestartLevel();
            }

        }
    }
}
