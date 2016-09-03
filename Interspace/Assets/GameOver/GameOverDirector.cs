using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverDirector : MonoBehaviour {

	GameObject scoreText;

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("ScoreText");
		UpdateScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Main");
		}
	}

	void UpdateScoreText () {
		this.scoreText.GetComponent<Text> ().text = "SCORE: " + Score.Instance.getScore ();
	}
}
