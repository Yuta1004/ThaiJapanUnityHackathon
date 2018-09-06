using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToTitleButton : MonoBehaviour {

	public void OnClick() {
		FadeManager mFadeManager = FadeManager.Instance;
		mFadeManager.LoadScene("Title", 2.0f);
	}
}
