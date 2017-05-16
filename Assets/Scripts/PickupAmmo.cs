using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAmmo : MonoBehaviour {

	// Reference to AudioClip to play
	public AudioClip shootSFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

			
	}

	void OnCollisionEnter (Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManagerShoot.gameM) {
			if (GameManagerShoot.gameM.gameIsOver)
				return;
		}
		if (newCollision.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (shootSFX, gameObject.transform.position);
			GameManagerShoot.gameM.ChargeAmmo ();
			// destroy self
			Destroy (gameObject);
			return;
		}
	}
		
}
