using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour {
    Rigidbody rb;
    public float gateRateUP;
    public float gateRateDown;
    bool startPos = true;
   // bool endPos = false;
    // Transform startVec = transform.position;
    // Vector3 endVec = transform.position;
    Vector3 startVec;
    Vector3 endVec;


    // Use this for initialization
    void Start () {
        startVec = transform.position;
        endVec = transform.position;
        endVec.y += 3;
        

	}
	
	// Update is called once per frame
	void Update () {
        if(startPos == true)
        {
            startPos = false;
            transform.localPosition += (endVec - startVec) / (gateRateUP * Time.deltaTime);
        }
		
	}
}

//if, not in up position, wait 2(public var) seconds and shoot up a SET amount
//if in upwards position, slowly return to resting position. then reset
//need a start transform, and an ending transform, need a distance to move over a certain amount of time
//we can divide distance/time to get it to close at that rate