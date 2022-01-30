using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownPowerup : Powerup // Inheritance
{
    public override void ActivatePowerup(GameObject player) // POLYMORPHISM
    {
        // GameObject player = GameObject.Find("Player");
        player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
