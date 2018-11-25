using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightPickUp : MonoBehaviour {

    public GameObject flashLight;
    public Light light;
    private Toggle_Flashlight flash;
    public GameObject DoorToDestroy;


	// Use this for initialization
	void Start () {
        flash = flashLight.GetComponent<Toggle_Flashlight>();
	}

    private void OnTriggerEnter(Collider other)
    {
        //checks the tag of the collider to see if it's the player.
        if(other.tag == "Player")
        {
            //give the powerup and destroy the pickup.
            flash.SetPower(true);
            Destroy(light);
            Destroy(DoorToDestroy);
            Destroy(gameObject);
        }
    }
}
