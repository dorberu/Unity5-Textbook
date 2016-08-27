﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;
	Animator animator;
	float jumpForce = 680.0f;
	float walkForce = 30.0f;
	float maxWalkSpeed = 2.0f;
	float threshold = 0.2f;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10) {
			SceneManager.LoadScene("GameScene");
		}

		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0))
			&& this.rigid2D.velocity.y == 0) {
			this.animator.SetTrigger ("JumpTrigger");
			this.rigid2D.AddForce (transform.up * this.jumpForce);
		}

		int key = 0;
		if (Input.GetKey (KeyCode.RightArrow) || Input.acceleration.x > this.threshold) key = 1;
		if (Input.GetKey (KeyCode.LeftArrow) || Input.acceleration.x < -this.threshold) key = -1;

		float speedx = Mathf.Abs (this.rigid2D.velocity.x);

		if (speedx < this.maxWalkSpeed){
			this.rigid2D.AddForce (transform.right * key * this.walkForce);
		}

		if (key != 0)
		{
			transform.localScale = new Vector3 (key, 1, 1);
		}

		if (this.rigid2D.velocity.y == 0) {
			this.animator.speed = speedx / 2.0f;
		} else {
			this.animator.speed = 1.0f;
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("ゴール");
		SceneManager.LoadScene ("ClearScene");
	}
}
