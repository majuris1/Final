using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	public string s = Slide; 

	void OnCollisionEnter2D(Collision2D coll)
	{
		var player = coll.gameObject.GetComponent<Player>();
		coll.GetComponent<Collider2D>();
		if (gameObject.GetComponent<coll>)
			StartCoroutine("Slide");
	}
	IEnumerator Slide() 
	{
		if(Input.GetKeyDown("s"))
			GetComponent<Collider2D>().SetActive(false);
	}

}