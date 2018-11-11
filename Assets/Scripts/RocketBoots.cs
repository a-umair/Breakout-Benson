using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBoots : MonoBehaviour {

    //really long but not an issue.
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController control;
    public float newJumpHeight = 11.0f;

	// Use this for initialization
	void Start ()
    {
        control = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
	}

    // Update is called once per frame
    void Update()
    {

    }

    //basically a function to increase the fpscontroller.
    //We need to change the JumpSpeed.
    public void HighJump()
    {
        control.setJumpSpeed(newJumpHeight);
    }

}
