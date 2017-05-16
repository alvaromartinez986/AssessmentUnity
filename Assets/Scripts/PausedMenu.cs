using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PausedMenu : MonoBehaviour {


	public Transform canvas;
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P)) {

			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
				player.GetComponent<FirstPersonController> ().enabled= false;

			} else {
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
				player.GetComponent<FirstPersonController> ().enabled= true;

			}
		
		}
	}
}
