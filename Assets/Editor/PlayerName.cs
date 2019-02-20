using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerName : MonoBehaviour {

	public InputField Name;

	public dreamloLeaderBoard dl;

	void start(){

		//dl = FindObjectOfType<dreamloLeaderBoard>();
	}

	public void NameEnter(string newName){

		dl.AddScore(newName, PlayerPrefs.GetInt("CurrentScore"));

		PlayerPrefs.DeleteKey ("CurrentScore");

		SceneManager.LoadScene ("Menu");

	}
		
}
