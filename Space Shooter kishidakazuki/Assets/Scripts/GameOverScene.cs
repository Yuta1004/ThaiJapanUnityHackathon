using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour {
	public Text ScoreText;

	// Use this for initialization
	void Start () {
		int score = GameController.GetScore();
		ScoreText.text = score.ToString();
	}
}
