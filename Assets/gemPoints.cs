using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(AudioSource))]
public class gemPoints : MonoBehaviour {

    // Use this for initialization
    public int scoreAdded;
    AudioSource rupee;
    void Start () {
        rupee = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        var playerController = other.GetComponent<FirstPersonController>();
        if (playerController.tag != null)
        {
            playerController.score += scoreAdded;
            rupee.Play();
            Destroy(gameObject, .10f);
        }
    }
}
