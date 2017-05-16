using UnityEngine;
using System.Collections;

public class TargetBehavior : MonoBehaviour
{

	// target impact on game
	public int scoreAmount = 0;
	public float timeAmount = 0.0f;

	// explosion when hit?
	public GameObject explosionPrefab;

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManagerShoot.gameM) {
			if (GameManagerShoot.gameM.gameIsOver)
				return;
		}
			
		if (gameObject.tag == "Projectile") {
			Destroy (gameObject);
			return;
		}

		if (newCollision.gameObject.tag == "Projectile" && gameObject.tag == "Player") {
			GameManagerShoot.gameM.PlayerDead ();
			return;
		}
		
		
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile"  && gameObject.tag != "Player") {
			if (explosionPrefab) {
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefab, transform.position, transform.rotation);
			}

			// if game manager exists, make adjustments based on target properties
			if (GameManagerShoot.gameM) {
				GameManagerShoot.gameM.targetHit (scoreAmount);
			}
				
			// destroy the projectile
			Destroy (newCollision.gameObject);
				
			// destroy self
			Destroy (gameObject);
		}
	}
}
