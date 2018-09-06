using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using JetBrains.Annotations;
using UnityEngine;

public class HelpPopupWindow : MonoBehaviour {
	public Canvas PopupCanvas;
	public CanvasGroup MCanvasGroup;

	private Boolean _isFade;

	void Start() {
		MCanvasGroup.alpha = 0.0f;
	}

	void Update() {
		if (_isFade) {
			MCanvasGroup.alpha -= 0.10f;
		}

		if (MCanvasGroup.alpha <= 0.0f) {
			PopupCanvas.enabled = false;
			_isFade = false;
		}
	}

	public void OnClick() {
		_isFade = true;
	}
}
