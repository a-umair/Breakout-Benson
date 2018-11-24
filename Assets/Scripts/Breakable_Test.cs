using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable_Test : MonoBehaviour {

    public int TotalHealth = 100;
    private int health;
    Renderer rend;

    // Use this for initialization
    void Start ()
    {
        health = TotalHealth;
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Projectile")
        {
            health = health - (TotalHealth/2);
            Destroy(collision.gameObject);
            //Set the main Color of the Material to red, to show it's damaged.
            rend.material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update ()
    {
		if(health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
