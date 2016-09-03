using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainDirector : MonoBehaviour {

	GameObject scoreText;

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("ScoreText");
		Score.Instance.initTime ();
		UpdateScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
		Score.Instance.addTime (Time.deltaTime);
		UpdateScoreText ();
	}

	void UpdateScoreText () {
		this.scoreText.GetComponent<Text> ().text = "SCORE: " + Score.Instance.getScore ();
	}
}
