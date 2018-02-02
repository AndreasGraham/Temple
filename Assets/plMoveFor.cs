using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class plMoveFor : MonoBehaviour {

    List<Transform> passengers = new List<Transform>();

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
	void Update ()
    {
        Vector3 originalPosition = transform.position;
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
        Vector3 delta = (transform.position - originalPosition);

        for(int i = 0; i < passengers.Count; ++i)
        {
            passengers[i].Translate(delta, Space.World);
        }
        
	}

    void OnControllerColliderHit(ControllerColliderHit other)
    {
        var playerController = other.collider.GetComponent<FirstPersonController>();
        if(other.collider.tag == "Player")
        {
            Debug.Log("PASSENGER ADDED");
            passengers.Add(playerController.transform);
        }
    }
    void OnCollisionExit(Collision other)
    {
        var playerController = other.collider.GetComponent<FirstPersonController>();
        if (other.collider.tag == "Player")
        {
            Debug.Log("PASSENGER REMOVED");
            passengers.Remove(playerController.transform);
        }
    }
}
// on trigger enter, parent player to block, on trigger enter set to null