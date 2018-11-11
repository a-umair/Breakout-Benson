using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBootsPickup : MonoBehaviour {

    public GameObject Player;
    private RocketBoots boots;


    // Use this for initialization
    void Start()
    {
        boots = Player.GetComponent<RocketBoots>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //checks the tag of the collider to see if it's the player.
        if (other.tag == "Player")
        {
            boots.HighJump();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //destroy the pickup once we know the player has the powerup.
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
