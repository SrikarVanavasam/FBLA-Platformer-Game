using UnityEngine;

[RequireComponent(typeof(Player2))]
public class PlayerInput2 : MonoBehaviour
{
	private Player2 player;

	private void Start()
	{
		player = GetComponent<Player2>();
	}

	private void Update()
	{
		Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal2"), Input.GetAxisRaw("Vertical2"));
		player.SetDirectionalInput(directionalInput);

		if (Input.GetButtonDown("Jump2"))
		{
			player.OnJumpInputDown();
		}

		if (Input.GetButtonUp("Jump2"))
		{
			player.OnJumpInputUp();
		}
	}
}
