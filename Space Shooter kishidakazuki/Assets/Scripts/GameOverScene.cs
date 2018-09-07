using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour {
	public Text ScoreText;
	public Text RankText;

	// Use this for initialization
	void Start () {
		int score = GameController.GetScore();
		ScoreText.text = score.ToString();
		RankText.text = GetRank(score);
	}

	string GetRank(int score) {
		if (score >= 2000) {
			return "S";
		}
		
		if (score >= 1500) {
			return "A";
		}
		
		if (score >= 1000) {
			return "B";
		}
		
		if (score >= 600) {
			return "C";
		}
		
		if (score >= 300) {
			return "D";
		}

		return "F";
	}
}
