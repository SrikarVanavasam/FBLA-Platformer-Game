using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public int currentScore;

	public void NewGameBtn(string newGameLevel)
	{
		PlayerPrefs.SetInt ("CurrentScore", currentScore);

		SceneManager.LoadScene(newGameLevel);
	}

	public void QuitGameBtn(){

		PlayerPrefs.DeleteAll();
		Application.Quit();
	}

}
