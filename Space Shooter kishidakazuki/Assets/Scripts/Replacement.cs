using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacement : MonoBehaviour {

    public bool isSelect;

	void Start(){
        if(isSelect){
            this.transform.position = new Vector3(0, 0.1f, -0.5f);
        }else{
            this.transform.position = new Vector3(0, -30, -10);
        }
	}

	void Updown(){
        if (isSelect){
            this.transform.position = new Vector3(0, 0.1f, -0.5f);
        }
        else{
            this.transform.position = new Vector3(0, -30, -10);
        }
    }
}
