using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMachine : MonoBehaviour {


	// Reference to projectile prefab to shoot
	public GameObject projectile;

    float shootTime = 0;
	public float velShoot = 15.0f;
	float distanceShoot = 30;

	public float power = 10.0f;

	public Vector3 direction;

	// Reference to AudioClip to play
	public AudioClip shootSFX;

	// Use this for initialization
	void Start () {
		shootTime = Time.time + velShoot;
	}
	
	// Update is called once per frame
	void Update () {
		// Detect if fire button is pressed

		if (distanceShoot >= DistancePlayer ()) {
			if (Time.time >= shootTime) {	
						
				// if projectile is specified
				if (projectile) {
					// Instantiante projectile at the camera + 1 meter forward with camera rotation
					GameObject newProjectile = Instantiate (projectile, transform.position + transform.forward, transform.rotation) as GameObject;

					// if the projectile does not have a rigidbody component, add one
					if (!newProjectile.GetComponent<Rigidbody> ()) {
						newProjectile.AddComponent<Rigidbody> ();
					}
					GameObject player = GameObject.FindGameObjectWithTag ("Player");

					gameObject.transform.LookAt (player.transform);

					// Apply force to the newProjectile's Rigidbody component if it has one
					newProjectile.GetComponent<Rigidbody> ().AddForce (gameObject.transform.forward * power, ForceMode.VelocityChange);

					// play sound effect if set
					if (shootSFX) {
						if (newProjectile.GetComponent<AudioSource> ()) { // the projectile has an AudioSource component
							// play the sound clip through the AudioSource component on the gameobject.
							// note: The audio will travel with the gameobject.
							newProjectile.GetComponent<AudioSource> ().PlayOneShot (shootSFX);
						} else {
							// dynamically create a new gameObject with an AudioSource
							// this automatically destroys itself once the audio is done
							AudioSource.PlayClipAtPoint (shootSFX, newProjectile.transform.position);
						}
					}


				}

				shootTime = Time.time + velShoot;
			}
		}
	}

	float DistancePlayer(){

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		float distance = Vector3.Distance (player.transform.position, gameObject.transform.position);
		return distance;
	}
}
