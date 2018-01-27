using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LavaDmg : MonoBehaviour {

    // Use this for initialization
    public float damage;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        var playerController = other.GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.health -=  damage *Time.deltaTime;
        }
    }

}
