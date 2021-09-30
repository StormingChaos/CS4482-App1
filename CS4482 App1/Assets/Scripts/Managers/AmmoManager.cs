using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public static int ammo;         // The player's ammo count
    public int startingAmmo;        // starting ammo count
    Text text;                      // Reference to the Text component.

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        // Reset the starting ammo.
        ammo = startingAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the displayed text to be the word "Ammo" followed by the ammo value.
        text.text = "Ammo: " + ammo;
    }
}
