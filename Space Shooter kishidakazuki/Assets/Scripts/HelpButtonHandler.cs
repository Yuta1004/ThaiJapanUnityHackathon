using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButtonHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		FadeManager mFadeManager = FadeManager.Instance;
		mFadeManager.LoadScene("Help", 2.0f);
	}
}
