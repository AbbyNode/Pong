using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// Public vars
	public float speed;

	// Private vars
	private Rigidbody2D rBody;

	// Use this for initialization
	void Start() {
		rBody = this.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		float vMove = Input.GetAxis("Vertical");
		rBody.velocity = new Vector2(0, vMove) * speed;
	}

	// Update is called once per frame
	void Update() {

	}
}
