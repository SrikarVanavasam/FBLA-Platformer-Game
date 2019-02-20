using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer2 : MonoBehaviour {

	public int damageToGive;

	public PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {

		playerHealth = FindObjectOfType<PlayerHealth>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player2") {
			playerHealth.HurtPlayer1(damageToGive);
		}
	}
}
