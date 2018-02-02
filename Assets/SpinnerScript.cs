using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerScript : MonoBehaviour {

    public float rotationSpeed;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationSpeed, 0);
	}
}
