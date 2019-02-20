using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	private bool PlayerInZone;

	public string LevelToLoad;

	// Use this for initialization
	void Start () {

		PlayerInZone = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(PlayerInZone == true)
		{

			SceneManager.LoadScene (LevelToLoad);
		}
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.name == "Player") {

			PlayerInZone = true;

			ScoreManager.score = ScoreManager.score + (int)(15000f / Time.timeSinceLevelLoad); 

			PlayerPrefs.SetInt ("CurrentScore", ScoreManager.score);
		}

	}

	void OnTriggerExit2D(Collider2D other){

		if (other.name == "Player") {

			PlayerInZone = false;
		}

	}


}
