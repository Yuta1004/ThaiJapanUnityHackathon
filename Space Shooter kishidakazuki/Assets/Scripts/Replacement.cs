using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacement : MonoBehaviour {

    public int expansion;
    public bool isSelect;
    public Vector3 size;

    private Vector3 originSiza;
    private int count;

	void Start(){
        if(isSelect){
            this.transform.position = new Vector3(0.0f, 0.0f, 5.0f);
        }else{
            this.transform.position = new Vector3(0, -30, -10);
        }

        originSiza = size;
        count = 0;
	}

    public void Updown(bool Select){
        isSelect = Select;
        if (isSelect){
            this.transform.position = new Vector3(0.0f, 0.0f, 5.0f);
        }
        else{
            this.transform.position = new Vector3(0, -30, -10);
        }
    }

    public void Expansion(){
        size = new Vector3(size.x + expansion,
                           size.y + expansion,
                           size.z + expansion);
        count++;
        if (count >= 10){
            
            size = originSiza;
            count = 0;
        }
        this.transform.localScale = size;
    }
}
