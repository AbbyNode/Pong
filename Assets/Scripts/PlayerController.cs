using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public string inputAxis = "Vertical";
	public float speed = 5f;

	private Rigidbody2D rBody;


	// Use this for initialization
	void Start() {
		rBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update() {
		float moveVertical = Input.GetAxisRaw(inputAxis);
		rBody.velocity = new Vector2(0, moveVertical * speed);
	}
}
