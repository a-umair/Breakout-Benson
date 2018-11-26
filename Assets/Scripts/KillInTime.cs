using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillInTime : MonoBehaviour {
    public int TIMETOKILL = 10;
    private void Awake()
    {
        Destroy(gameObject, TIMETOKILL);
    }
}
