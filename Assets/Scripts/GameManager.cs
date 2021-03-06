﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Sprite[] numberSprites;
	public Sprite[] winSprites;

	public GameObject player1;
	public GameObject player2;

	public GameObject ball;

	public SpriteRenderer winMsg;
	public SpriteRenderer playerScore1;
	public SpriteRenderer playerScore2;

	public GameObject leftWall;
	public GameObject rightWall;

	private static int playerScore1_int;
	private static int playerScore2_int;

	// Use this for initialization
	void Start() {
		reset();
	}
	
	void reset() {
		playerScore1_int = 0;
		playerScore2_int = 0;
	}

	void updateScore() {
		playerScore1.sprite = numberSprites[playerScore1_int];
		playerScore2.sprite = numberSprites[playerScore2_int];
	}

	internal void CollisionDetected(ScoreWall scoreWall) {
		if (scoreWall.gameObject == rightWall || scoreWall.gameObject == leftWall) {
			if (scoreWall.gameObject == rightWall) {
				playerScore1_int++;
				if (playerScore1_int >= 11) {
					showWinMsg(1);
				} else {
					ball.GetComponent<BallMover>().resetBall();
				}
			} else if (scoreWall.gameObject == leftWall) {
				playerScore2_int++;
				if (playerScore2_int >= 11) {
					showWinMsg(2);
				} else {
					ball.GetComponent<BallMover>().resetBall();
				}
			}
			updateScore();
		}
	}

	void showWinMsg(int playerNum) {
		winMsg.sprite = winSprites[playerNum - 1];
	}
}
