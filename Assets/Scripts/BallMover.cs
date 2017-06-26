using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {
	// Public vars

	// Private vars
	private Rigidbody2D rBody;

	// Use this for initialization
	void Start () {
		rBody = this.GetComponent<Rigidbody2D>();
		rBody.velocity = new Vector2(-1, 0);
	}

	void FixedUpdate() {
	}
	
	// Update is called once per frame
	void Update () {
	}
}
