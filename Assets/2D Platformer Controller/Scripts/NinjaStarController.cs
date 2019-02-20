using UnityEngine;
using System.Collections;

public class NinjaStarController : MonoBehaviour {


	public float speed;

	public Player player;

	public int enemyPoints;

	// Use this for initialization
	void Start () {

		player = FindObjectOfType<Player>();

		if (player.firePoint.transform.localPosition.x < 0) {

			speed = -speed;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);

	}

	void OnTriggerEnter2D(Collider2D other){
	
		if (other.tag == "Enemy") {
		
			Destroy (other.gameObject);

			Destroy (gameObject);

			ScoreManager.AddPoints (enemyPoints);

		} else if (other.name == "Player2") {
			Destroy (gameObject);
		}else if (other.name == "Player" || other.name == "Sword") {
			return;
		} else {

			Destroy (gameObject);
		}
	}

}
