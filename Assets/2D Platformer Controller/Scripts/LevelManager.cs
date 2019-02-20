using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	public GameObject DeathParticle; 
	public GameObject LifeParticle; 
	public float RespawnDelay;

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
		
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
	

		Debug.Log ("Respawn Player");
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
		lifesystem.TakeLife ();
		ScoreManager.AddPoints (-pointPenaltyOnDeath);
		player.gameObject.SetActive(false); 
		yield return new WaitForSeconds (RespawnDelay);
		player.transform.position = currentCheckpoint.transform.position;
		Instantiate (LifeParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
		player.gameObject.SetActive(true); 
	}
}

