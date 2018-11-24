using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPickUp : MonoBehaviour {

    public GameObject Player;
    private Cannon cann;

	// Use this for initialization
	void Start ()
    {
        cann = Player.GetComponent<Cannon>();	
	}

    private void OnTriggerEnter(Collider other)
    {
        //checks the tag of the collider to see if it's the player.
        if (other.tag == "Player")
        {
            cann.setPower(true);
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
