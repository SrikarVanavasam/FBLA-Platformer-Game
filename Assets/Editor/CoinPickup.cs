﻿using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Player> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		Destroy (gameObject);
	}
}