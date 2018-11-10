using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Flashlight : MonoBehaviour {
    public bool on = false;
    private Light flashLight;


    void Start ()
    {
        flashLight = GetComponent<Light>();
	}

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.F))
            on = !on;
        if (on)
            flashLight.enabled = true;
        else if (!on)
            flashLight.enabled = false;
    }
}



