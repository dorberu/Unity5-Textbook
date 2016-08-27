using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LButtonDown () {
		transform.Translate (-3, 0, 0);
	}

	public void RButtonDown () {
		transform.Translate (3, 0, 0);
	}
}
