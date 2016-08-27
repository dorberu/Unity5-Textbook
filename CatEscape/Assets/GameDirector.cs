using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameDirector : MonoBehaviour {

	GameObject hpGauge;

	// Use this for initialization
	void Start () {
		this.hpGauge = GameObject.Find ("hpGauge");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DecreaseHp() {
		this.hpGauge.GetComponent<Image> ().fillAmount -= 0.1f; 
	}
}
