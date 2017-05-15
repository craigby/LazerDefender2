using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = ScoreKeeper.score.ToString();
		ScoreKeeper.Reset();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
