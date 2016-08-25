using UnityEngine;
using System.Collections;

public class RoultteController : MonoBehaviour {

	float rotSpeed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Stationary) {
				this.rotSpeed = 100.0f;
			}
		}

		if (Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 100.0f;
		}

		transform.Rotate (0, 0, this.rotSpeed);

		this.rotSpeed *= 0.96f;
	}
}
