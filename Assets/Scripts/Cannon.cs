using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public GameObject bullet;
    private bool power;

	// Use this for initialization
	void Start () {
        //prefab = Resources.Load("projectile") as GameObject;
        power = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (power)
        {
            if (Input.GetButtonUp("Fire1")) 
            {
                GameObject projectile = Instantiate(bullet) as GameObject;
                projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
                Rigidbody rigbo = projectile.GetComponent<Rigidbody>();
                rigbo.velocity = Camera.main.transform.forward * 56;
            }
        }
    }

    public void setPower(bool input)
    {
        power = input;
    }

}
