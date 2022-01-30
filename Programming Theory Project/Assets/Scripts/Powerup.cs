using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public virtual void ActivatePowerup(GameObject player)
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
