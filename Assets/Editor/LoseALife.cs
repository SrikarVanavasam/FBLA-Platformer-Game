using UnityEngine;
using System.Collections;

public class LoseALife : MonoBehaviour {

	public int pointsToAdd;

	public LifeManager lifeManager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Player> () == null)
			return;

		if (lifeManager.lifeCounter >= 3) {
			
			ScoreManager.AddPoints (pointsToAdd);

		} else if (lifeManager.lifeCounter < 3) {

			lifeManager.GiveLife ();
		}
		Destroy (gameObject);
	}
}
