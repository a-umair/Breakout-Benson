using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightPickUp : MonoBehaviour {

    public GameObject flashLight;
    private Toggle_Flashlight flash;


	// Use this for initialization
	void Start () {
        flash = flashLight.GetComponent<Toggle_Flashlight>();
	}

    private void OnTriggerEnter(Collider other)
    {
        //checks the tag of the collider to see if it's the player.
        if(other.tag == "Player")
        {
            flash.SetPower(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //destroy the pickup once we know the player has the powerup.
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
