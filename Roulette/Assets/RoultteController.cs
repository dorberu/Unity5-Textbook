﻿using UnityEngine;
using System.Collections;

public class RoultteController : MonoBehaviour {

	float rotSpeed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 100.0f;
		}

		transform.Rotate (0, 0, this.rotSpeed);

		this.rotSpeed *= 0.96f;
	}
}