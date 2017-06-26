using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
	public float yMin, yMax;
}

public class PlayerController : MonoBehaviour {
	// Public vars
	public Boundary boundary;
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
		rBody.position = new Vector2(rBody.position.x, Mathf.Clamp(rBody.position.y, boundary.yMin, boundary.yMax));
	}

	// Update is called once per frame
	void Update() {

	}
}
