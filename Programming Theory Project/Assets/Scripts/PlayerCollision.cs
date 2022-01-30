using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            /* 
            TODO: Change to FindWithTags <- more performant?
            That is true. Unity caches GameObjects based on their tags, so in a big scene with lots of objects, GameObject.FindWithTag is several orders of magnitudes faster that GameObject.Find.
            It still does not beat the simple deserialization of a direct public variable link (in terms of speed).
            Just for the record: Object.FindObjectOfType is A LOT slower than GameObject.Find. In our measurements, the relation is roughly: 10x GameObject.FindWithTag = GameObject.Find and 100x GameObject.Find = Object.FindObjectOfType.
            Of course, all that only matters if it really matters. 99% of the cases, it just does not matter so if you don't write a tight Update() function in a big scene targeting iPhone 3, go on with any method you like until you run into trouble.
            
            GameObject.Find is great when you have a small scene. GameObject.FindWithTag is better for larger scenes with 100s of gameObjects.
            public static Object FindObjectOfType(Type type); is useful somewhere, when you have a small scene and you want to find which object has that specific Type. It helps in refactoring other codes. 
            */
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            other.gameObject.GetComponent<Powerup>().ActivatePowerup(gameObject);
        }
        Debug.Log(other.gameObject.tag);
    }
}
