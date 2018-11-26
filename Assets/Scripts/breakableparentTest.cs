using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableparentTest : MonoBehaviour {

    //This script is just here for cleanup.
    //Whenever all the block chunks of the main block are destroyed,
    //the parent object kills itself since it no longer has children.
	void FixedUpdate () {
		if(!gameObject.GetComponentInChildren<Rigidbody>())
        {
            Destroy(gameObject);
        }
	}
}
