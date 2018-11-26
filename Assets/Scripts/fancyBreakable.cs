using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fancyBreakable : MonoBehaviour {
	public GameObject destroyed_block;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Projectile")
        {
            Vector3 velocity = collision.relativeVelocity; //get the velocity of the collision.
            GameObject test = Instantiate(destroyed_block, this.transform.position + 2*Vector3.down, this.transform.rotation) as GameObject;//idk seems fishy.
            Destroy(collision.gameObject);//kill the projectile
            Destroy(gameObject);//kill self
        }
    }
}
