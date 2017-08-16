using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {
	GameObject p1;
	GameObject p2;

	private void Start() {
		p1 = GameObject.Find("Player1");
		p2 = GameObject.Find("Player2");
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		p1.transform.localScale += new Vector3(0, 0.5f, 0);
		p2.transform.localScale += new Vector3(0, 0.5f, 0);
		Destroy(this.gameObject);
	}
}
