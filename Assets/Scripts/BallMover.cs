using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {
	public float initDelay = 1f;
	public float minSpeed = 10f;
	public float reflectScale = 2f;

	private Rigidbody2D rBody;

	void Start() {
		rBody = this.GetComponent<Rigidbody2D>();
		Invoke("initBall", initDelay);
	}
	
	void initBall() {
		int direction = (Random.value > 0.5 ? 1 : -1);
		float speed = minSpeed * direction;

		rBody.AddForce(new Vector2(speed, 0));
	}

	public void resetBall() {
		rBody.velocity = new Vector2(0, 0);
		gameObject.transform.position = new Vector2(0, 0);
		Invoke("initBall", initDelay);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.collider.CompareTag("Player")) {

			foreach (ContactPoint2D hitPoint in coll.contacts) {
				float xVel = Mathf.Min(rBody.velocity.x, minSpeed);
				float yVel = (hitPoint.point.y - coll.collider.transform.position.y) * reflectScale;
				rBody.velocity = new Vector2(xVel, yVel); ;
			}
		}
	}
}
