using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	public static DontDestroyOnLoad Instance { get; private set; }

	// シーン遷移してもSEを鳴らし続ける
	void Awake (){
		if (Instance == null) {
			Instance = this;
			DontDestroyOnLoad(Instance.gameObject);
		}
	}
}
