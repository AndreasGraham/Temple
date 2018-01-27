using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plMoveFor : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float moveDistance;
    Vector3 endLerpPos;
    float endPos; // slightly less than endLerpPos
    Vector3 startTransform;
    bool forward = true;
    bool back = false;
    float startPos; // slightly larger than startTransform
    
	void Start () {
        startTransform = transform.position;
        endLerpPos = transform.position + (transform.forward * moveDistance);
        //endLerpPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + moveDistance);
        //startTransform = transform.localPosition;
     
       startPos = startTransform.z + .4f;
       endPos = endLerpPos.z - .4f;

       
	}
	
	// Update is called once per frame
	void Update () {

        if(forward == true)
        {
            //if (transform.localPosition.z <= endLerpPos.z)
            //{
                transform.localPosition = Vector3.Lerp(transform.localPosition, endLerpPos, speed * Time.deltaTime);
            //}
            if(transform.localPosition.z >= endPos)
            {
                forward = false;
                back = true;
            }
        }

        if(back == true)
        {
            //if (transform.localPosition.z <= endPos)
            //{
                transform.localPosition = Vector3.Lerp(transform.localPosition, startTransform, speed * Time.deltaTime);
            //}
            if (transform.localPosition.z <= startPos)
            {
                back = false;
                forward = true;
            }
        }

        
	}
}
