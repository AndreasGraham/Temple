using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class gemPoints : MonoBehaviour {

    // Use this for initialization
    public int scoreAdded;
	void Start () {
		
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
            Destroy(gameObject);
        }
    }
}
