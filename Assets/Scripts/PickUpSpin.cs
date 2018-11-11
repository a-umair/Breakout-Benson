using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Pick Up Spin
//all this does is make the powerup spin 1 degree per frame.
//just makes the powerup stand out!

public class PickUpSpin : MonoBehaviour {
    private int rotate;
	// Use this for initialization
	void Start () {
        rotate = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(rotate >= 360) { rotate = 0; }
        gameObject.transform.Rotate(Vector3.up, rotate + 1);
	}
}
