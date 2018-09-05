using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLight : MonoBehaviour {

    public float tumble;

    private float rot_x;
    private float rot_y;
    private float rot_z;

	void Start(){

        rot_x = transform.localEulerAngles.x;
        rot_y = transform.localEulerAngles.y;
        rot_z = transform.localEulerAngles.z;
	}
    void Update(){
        rot_x += tumble;
        this.transform.rotation = Quaternion.Euler(rot_x, rot_y, rot_z);
    }
}
