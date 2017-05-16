using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{

		// exit if there is a game manager and the game is over
		if (GameManagerShoot.gameM) {
			if (GameManagerShoot.gameM.gameIsOver)
				return;
		}

		//When colide with the player game ends
		if (newCollision.gameObject.tag == "Player") {
			GameManagerShoot.gameM.gameIsOver = true;
			GameManagerShoot.gameM.state = 3;
			return;
		}

	}
}
