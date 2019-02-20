using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int maxPlayer1Health;

	public static int player1Health;

	public GameObject DeathParticle; 

	public GameObject gameOverScreen; 

	private Player2 player;

	static Text text1;

	public string Menu;


	//Use this for initialization
	void Start () {

		text1 = GetComponent<Text> ();

		player = FindObjectOfType<Player2>();

		player1Health = maxPlayer1Health;

	}

	// Update is called once per frame
	public void Update () {

		text1.text = "" + player1Health;
		if (player1Health == 0) {
			text1.text = "0";
			Player1Dies();
		} 
		if (Input.GetKeyDown(KeyCode.Space) && gameOverScreen.activeSelf) {

			Application.LoadLevel (Menu);
		}
	}

	public void Player1Dies(){

		gameOverScreen.SetActive (true);

		player.gameObject.SetActive (false);
	}

	public void HurtPlayer1(int damageToGive){

		player1Health = player1Health-damageToGive;
		if (player1Health <= 0) {
			player1Health = 0;
		}
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
	}

}
