using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthOn : MonoBehaviour {


	public Light ligthSpace;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// Ligth on, when player enter in a room
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player")
			ligthSpace.enabled = true;

	}

	//Ligth off, wehn player exit of a room
	void OnTriggerExit(Collider newCollision){
		if (newCollision.gameObject.tag == "Player")
			ligthSpace.enabled = false;
	}
}
