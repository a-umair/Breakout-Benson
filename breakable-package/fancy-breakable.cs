using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fancy-breakable : MonoBehaviour {
	public GameObject destroyed_block;

	public void blockDestroy(){

		GameObject block_destruction = Instantiate(destroyed_block, this.transform.position, this.transform.rotation) as GameObject;
		Destroy(gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		if(collision.collider.tag == "Projectile")
        {
            blockDestroy();
        }
	}
}
