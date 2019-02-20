using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

	public AudioClip myclip;
	public AudioSource audioSource;

	public Text theText;

	public GameObject GameWin;

	public float wait;

	dreamloLeaderBoard dl;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return) && GameWin.gameObject.activeSelf) {

			SceneManager.LoadScene ("PlayerName");
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player") {

			ScoreManager.score = ScoreManager.score + (int)(15000f / Time.timeSinceLevelLoad); 

			PlayerPrefs.SetInt ("CurrentScore", ScoreManager.score);

			audioSource.PlayOneShot(myclip);

			GameWin.SetActive (true);
		}
	}
}
