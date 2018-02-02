using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class fallDamage : MonoBehaviour {

    // Use this for initialization
    //public RigidBody rb;
    public float fDamage = 25;
    public float velocity = -30;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        var playerController = other.GetComponent<FirstPersonController>();
        CharacterController rb = playerController.GetComponent<CharacterController>();
        if(rb.velocity.y <= velocity)
        {
            playerController.health -= fDamage;
        }
    }
}
