using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPickUp : MonoBehaviour {

    public GameObject Player;
    public GameObject lights;
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
            Destroy(lights);
            Destroy(gameObject);
        }
    }
}
