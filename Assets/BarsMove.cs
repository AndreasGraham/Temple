using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarsMove : MonoBehaviour {
    //   public float moveTime;
    public float moveTime; //speed
    public float Distance;
    Vector3 endLerpPos;
    float endPos;
    float startPos;
    Vector3 startTransform;
    bool up = false;
    bool down = true;
    void Start()
    {
        endLerpPos = transform.position + (transform.forward * Distance);       // new Vector3(transform.localPosition.x, transform.localPosition.y - Distance, transform.localPosition.z);
        startTransform = transform.position;
        //StartCoroutine(CoroutineScaling());

        startPos = startTransform.y + .4f;
        endPos = endLerpPos.y - .4f;
    }

   /* IEnumerator CoroutineScaling()
    {
        //while(transform.localScale.x < scaleSize.x && transform.localScale.y < scaleSize.y && transform.localScale.z < scaleSize.z)
        //{
        //    transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        //}

        while (transform.localScale != scaleSize)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, scaleSize, scaleTime * Time.deltaTime);
            yield return new WaitForSeconds(scaleTime);
        }
    }*/

    void Update()
    {
        if(down == true)
        {
           
            transform.localPosition = Vector3.Lerp(transform.localPosition, endLerpPos, moveTime * Time.deltaTime);

            if(transform.localPosition.y > endPos)
            {
                down = false;
                up = true;
            }
        }
       
        /*else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, startTransform, moveTime * Time.deltaTime);
        }*/
        if(up == true)
        {
       
    
            transform.localPosition = Vector3.Lerp(transform.localPosition, startTransform, moveTime * Time.deltaTime);
            
            if(transform.localPosition.y < startPos)
            {
                down = true;
                up = false;
            }
        }
        
    }

    // need the difference between the desired scale and the current scale
    // need to incrementally scale up from current scale to desired scale over the set period of time
    // divide difference in scale by the amount of aloted time to incrementally reach desired size


}