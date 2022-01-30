using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public virtual void ActivatePowerup(GameObject player)
    {

    }

    private void OnTriggerEnter(Collider other)  // ENCAPSULATION
    {
        Destroy(gameObject);
    }
}
