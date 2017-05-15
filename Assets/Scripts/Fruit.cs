using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public int lives = 1;

	private void OnTriggerEnter2D(Collider2D coll)
	{
		var player = coll.gameObject.GetComponent<Player>();
		if(player != null) {
			gameObject.SetActive(false);
			FindObjectOfType<GM>().SetLives(FindObjectOfType<GM>().GetLives() + 1);
		}
    }
}
