using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer1 : MonoBehaviour {

	public int damageToGive;

	public Player2Health player2Health;

	// Use this for initialization
	void Start () {

		player2Health = FindObjectOfType<Player2Health>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player") {

			player2Health.HurtPlayer2 (damageToGive);
		}
	}
}
