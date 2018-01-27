using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormDown : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public float moveDistance;
    Vector3 endLerpPos;
    float endPos; // slightly less than endLerpPos
    Vector3 startTransform;
    bool forward = true;
    bool back = false;
    float startPos; // slightly larger than startTransform

    void Start()
    {
        startTransform = transform.position;
        endLerpPos = transform.position + (-transform.up * moveDistance);
        //endLerpPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + moveDistance);
        //startTransform = transform.localPosition;

        startPos = startTransform.y - .4f;
        endPos = endLerpPos.y + .4f;


    }

    // Update is called once per frame
    void Update()
    {

        if (forward == true)
        {
            //if (transform.localPosition.z <= endLerpPos.z)
            //{
            transform.localPosition = Vector3.Lerp(transform.localPosition, endLerpPos, speed * Time.deltaTime);
            //}
            if (transform.localPosition.y <= endPos)
            {
                forward = false;
                back = true;
            }
        }

        if (back == true)
        {
            //if (transform.localPosition.z <= endPos)
            //{
            transform.localPosition = Vector3.Lerp(transform.localPosition, startTransform, speed * Time.deltaTime);
            //}
            if (transform.localPosition.y >= startPos)
            {
                back = false;
                forward = true;
            }
        }


    }
}
