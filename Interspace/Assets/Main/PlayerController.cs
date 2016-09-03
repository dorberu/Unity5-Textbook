using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpPower;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, jumpPower, 0);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "DeadLine") {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
