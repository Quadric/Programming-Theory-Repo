using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownPowerup : Powerup // INHERITANCE
{
    public override void ActivatePowerup(GameObject player) // POLYMORPHISM
    {
        // GameObject player = GameObject.Find("Player");
        player.transform.GetComponent<PlayerMovement>().forwardForce = 2000.0f;
    }
}
