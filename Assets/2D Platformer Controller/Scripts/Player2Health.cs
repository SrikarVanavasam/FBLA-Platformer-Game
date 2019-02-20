using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player2Health : MonoBehaviour {

	public int maxPlayer2Health;

	public static int player2Health;

	private Player player;

	public GameObject DeathParticle; 

	public GameObject gameOverScreen; 

	public string Menu;

	static Text text2;

	// Use this for initialization
	void Start () {

		text2 = GetComponent<Text> ();

		player = FindObjectOfType<Player>();


		player2Health = maxPlayer2Health;

	}
	
	// Update is called once per frame
	void Update () {

		text2.text = "" + player2Health;
		if (player2Health == 0) {
			text2.text = "0";
			Player2Dies();
		}
		if (Input.GetKeyDown(KeyCode.Space) && gameOverScreen.activeSelf) {

			Application.LoadLevel (Menu);
		}
	}

	public void Player2Dies(){

			gameOverScreen.SetActive (true);

			player.gameObject.SetActive (false);
		}	

	public void HurtPlayer2(int damageToGive){

		player2Health = player2Health - damageToGive;
		if (player2Health <= 0) {
			player2Health = 0;
		}
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
	
	}

}
