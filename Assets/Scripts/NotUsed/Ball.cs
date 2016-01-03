﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//private Paddle paddle;

	private bool started;
	private Vector3 paddleToBallVector;



	// Use this for initialization
	void Start () {
	//	paddle = GameObject.FindObjectOfType<Paddle>();
	//	paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (!started) {
		//	this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0)) {
				started = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Vector2 tweak = new Vector2 (Random.Range(0f, 0.8f), Random.Range(0f, 0.1f));

		if (started) {
	//		GetComponent<AudioSource>().Play();
			GetComponent<Rigidbody2D>().velocity += tweak;
		}
	}


}
