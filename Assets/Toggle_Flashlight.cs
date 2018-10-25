using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_Flashlight : MonoBehaviour {
    public bool on = false;
  
    void Start () {
		
	}

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.F))
            on = !on;
        if (on)
            GetComponent<Light>().enabled = true;
        else if (!on)
            GetComponent<Light>().enabled = false;
    }
}



