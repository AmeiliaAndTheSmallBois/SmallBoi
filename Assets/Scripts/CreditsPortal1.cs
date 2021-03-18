using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsPortal : MonoBehaviour
{
	[SerializeField]
	public PlayerOne player1;
	[SerializeField]
	public PlayerTwo player2;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Outside If");
		Debug.Log(collision.gameObject);
		if (collision.gameObject.CompareTag("player 1"))
		{
			Debug.Log("Teleporting.....");
			SceneManager.LoadScene("Level2");
		}

		if (collision.gameObject.CompareTag("player 2"))
		{
			SceneManager.LoadScene("Level2");
		}
	}
}
