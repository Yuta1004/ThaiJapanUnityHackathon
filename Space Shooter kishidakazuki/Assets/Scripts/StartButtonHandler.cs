using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour {

	public void OnClick() {
//		SceneManager.LoadScene("stage1");
	
		FadeManager mFadeManager = FadeManager.Instance;
		mFadeManager.LoadScene("StartAnimation", 2.0f);
	}
}
