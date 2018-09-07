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
		if (score >= 12000) {
			return "S";
		}
		
		if (score >= 10000) {
			return "A";
		}
		
		if (score >= 8000) {
			return "B";
		}
		
		if (score >= 6000) {
			return "C";
		}
		
		if (score >= 3000) {
			return "D";
		}

		return "F";
	}
}
