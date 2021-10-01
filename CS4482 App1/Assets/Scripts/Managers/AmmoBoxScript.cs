using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxScript : MonoBehaviour
{
    //reference to player
    GameObject player;
    //sound clip for picking up ammo
    public AudioClip ammoClip;

    //default ammo in ammo box
    public int ammoCount = 10;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range to pick up the ammo box
            PickUp();
        }
    }

    void PickUp()
    {
        //play sound clip
        AudioSource.PlayClipAtPoint(ammoClip, transform.position);
        //add ammo to player
        AmmoManager.ammo += ammoCount;

        //destroy ammo box
        Destroy(gameObject);
    }
}
