using UnityEngine;
using System.Collections;

public class Score {

	public readonly static Score Instance = new Score();

	public float time = 0.0f;

	public void initTime () {
		this.time = 0.0f;
	}

	public void addTime (float addTime) {
		this.time += addTime;
	}

	public string getScore () {
		float score = this.time * 10;
		return score.ToString ("F0");
	}
}
