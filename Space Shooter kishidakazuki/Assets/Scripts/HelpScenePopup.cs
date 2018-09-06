using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpScenePopup : MonoBehaviour {

	public Canvas PopupCanvas;
	public CanvasGroup PopupCanvasGroup;
	public String Title;
	[Multiline] public String Description;

	void Start() {
		PopupCanvas.enabled = false;
	}

	void Update() {
		if (PopupCanvas.enabled) {
			PopupCanvasGroup.alpha += 0.05f;
		}
	}

	public void OnClick() {
		foreach (Transform child in PopupCanvas.transform){
			if(child.name == "PopupTitle"){
				Text title = child.gameObject.GetComponent<Text>();
				title.text = Title;
			}else if (child.name == "PopupDescription") {
				Text description = child.gameObject.GetComponent<Text>();
				description.text = Description;
			}
		}
		
		PopupCanvas.enabled = true;
	}
}
