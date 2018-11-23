using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Flashlight : MonoBehaviour {
    private bool on = false;
    private Light flashLight;
    private bool hasPower;

    //runs once
    void Start ()
    {
        hasPower = false;
        on = false;
        flashLight = GetComponent<Light>();//getting the component once is more efficent.
	}

    //runs every frame. No WHILE or FOR loops here!
    void Update()
    {
        if(hasPower)
        {
            if (Input.GetKeyDown(KeyCode.F))
                on = !on;
        }

        if (on)
            flashLight.enabled = true;
        else if (!on)
            flashLight.enabled = false;
    }

    public void SetPower(bool state)
    {
        hasPower = state;
    }
}



