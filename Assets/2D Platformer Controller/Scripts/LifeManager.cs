using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	public int startingLives;
	public int lifeCounter;

	public Text theText;

	public GameObject gameOverScreen;

	public Player player;

	public string Menu;

	public float waitAfterGameOver;

	// Use this for initialization
	void Start () {

		theText = GetComponent<Text>();

		lifeCounter = startingLives;

		player = FindObjectOfType<Player>();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (lifeCounter <= 0) {

			gameOverScreen.SetActive (true);


			player.gameObject.SetActive (false);
		}

		theText.text = "x " + lifeCounter;

//		if (gameOverScreen.activeSelf) {
//
//			waitAfterGameOver -= Time.deltaTime;
//		}

		if (Input.anyKey && gameOverScreen.activeSelf) {

			Application.LoadLevel (Menu);
		}

	}

	public void GiveLife()
	{
		lifeCounter++;
	}

	public void TakeLife()
	{
		lifeCounter--;
	}
}
