using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	private Player player;

	public int pointPenaltyOnDeath;

	private LifeManager lifesystem;

	// Use this for initialization
	void Start () {
	
		player = FindObjectOfType<Player>();

		lifesystem = FindObjectOfType<LifeManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		Debug.Log("Respawn Player");
		lifesystem.TakeLife();
		ScoreManager.AddPoints (-pointPenaltyOnDeath);
		player.transform.position = currentCheckpoint.transform.position;
	}
}
