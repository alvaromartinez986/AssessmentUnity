using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {


	public Button startButton;
	public Button exitButton;

	public GameObject startMenu;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void PressPlay(){
	}


	public void QuitGame(){
		Application.Quit ();
	}

	public void StartGame(){
		startMenu.active = false;
		GameManagerShoot.gameM.StartGame();
	}
}
