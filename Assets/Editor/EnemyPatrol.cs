using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

	public float moveSpeed;

	public bool moveRight;

	private float enemyTime;

	// Use this for initialization
	public enum OccilationFuntion { Sine, Cosine }

	public void Start ()
	{
		//to start at zero
		StartCoroutine (Oscillate (OccilationFuntion.Sine, 2f));
		//to start at scalar value
		//StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
	}

	private IEnumerator Oscillate (OccilationFuntion method, float scalar)
	{
		while (true)
		{
			if (method == (OccilationFuntion.Sine))
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2 (Mathf.Sin (Time.time) * scalar, GetComponent<Rigidbody2D>().velocity.y);
			}
			else if (method == (OccilationFuntion.Cosine))
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(Time.time) * scalar, GetComponent<Rigidbody2D>().velocity.y);
			}
			yield return new WaitForEndOfFrame ();
		}
	}
}

