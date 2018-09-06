using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ShakeObject : MonoBehaviour {
	public float Speed = 4.0f;
	public float Amount = 1.5f;

	void Update () {
		float y = Mathf.Sin(Time.time * Speed) * Amount + 2;
		Vector3 pos = gameObject.transform.position;
		gameObject.transform.position = new Vector3 (pos.x, y, pos.z);	
	}
}
