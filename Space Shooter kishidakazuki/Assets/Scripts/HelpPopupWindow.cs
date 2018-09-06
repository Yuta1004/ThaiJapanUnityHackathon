using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPopupWindow : MonoBehaviour {

	public void OnClick() {
		gameObject.transform.GetComponent<Canvas>().enabled = false;
	}
}
