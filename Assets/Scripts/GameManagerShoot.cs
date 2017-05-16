using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;



public class GameManagerShoot : MonoBehaviour {


	// State of game 0 is menu start, 1 game, 2 pause, 3 end game
	public int state = 0;
	public static GameManagerShoot gameM;
	public GameObject player;
	public GameObject enviroment;
	public GameObject posPlayer;


	//Labels
	public Text mainScoreDisplay;
	public Text mainLivesDisplay;
	public Text mainAmmoDisplay;
	public Text mainFinalScore;


	//configiurations of players
	public int score = 0;
	public int lives = 2;
	public int ammo = 0;

	// Reference to AudioClip to play
	public AudioClip deadSFX;

	public bool gameIsOver = false;

	public GameObject screenFinal;




	// Use this for initialization
	void Start () {
		gameM = this.gameObject.GetComponent<GameManagerShoot>();
		player.SetActive(false);
		screenFinal.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if (state == 1) {

			mainScoreDisplay.text = "Score :" + score.ToString ();
			mainLivesDisplay.text = "Lives :" + lives.ToString ();
			mainAmmoDisplay.text = "Ammo :" + ammo.ToString ();
		} else {

			if (state == 3) {
				mainFinalScore.text = "  GAME OVER!!! Score :" + score.ToString ();
				mainScoreDisplay.enabled = false;
				mainLivesDisplay.enabled = false;
				mainAmmoDisplay.enabled = false;
				screenFinal.SetActive (true);
				player.SetActive(false);
				enviroment.SetActive (false);
			}
		}
		
	}


	// public function that can be called to update the score or time
	public void targetHit (int scoreAmount)
	{
		// increase the score by the scoreAmount and update the text UI
		score += scoreAmount;
		mainScoreDisplay.text = "Score :"+score.ToString ();

	}


	//Respawn player or gameover
	public void PlayerDead(){
		lives--;
		if (lives < 0) {
			gameIsOver = true;
			state = 3;

		} else {
			AudioSource.PlayClipAtPoint (deadSFX, player.transform.position);
			mainLivesDisplay.text = "Lives :"+lives.ToString ();
			player.transform.position = posPlayer.transform.position;
		}
	}



	public void ChargeAmmo(){
		ammo += 25;
	}


	public void StartGame(){
		state = 1;
		player.SetActive(true);
		enviroment.SetActive (true);
	}
}
