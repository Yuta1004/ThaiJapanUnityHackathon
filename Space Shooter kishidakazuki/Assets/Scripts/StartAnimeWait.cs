using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAnimeWait : MonoBehaviour {

	public Animation MAnimation;
	private Boolean _endAnimation = false;
	
	// Update is called once per frame
	void Update () {
		if (!MAnimation.isPlaying && !_endAnimation) {
			FadeManager mFadeManager = FadeManager.Instance;
			mFadeManager.LoadScene("stage1", 0.3f);
			_endAnimation = true;
		}
	}
}
