using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacement : MonoBehaviour {

    public int expansion;
    public bool isSelect;
    public Vector3 size;

    private Vector3 originSiza;
    private int count;
    private GameController gameController;

	void Start(){

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null){

            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null){

            Debug.Log("Cannot find 'GameController' script");
        }

        if(isSelect){
            this.transform.position = new Vector3(0.0f, 0.0f, 5.0f);
        }else{
            this.transform.position = new Vector3(0, -30, -10);
        }

        originSiza = size;
        count = 0;
	}

    public void ViewTrashBag(bool select, Vector3 playerBack) {
        isSelect = select;
        gameObject.SetActive(select);
        transform.position = playerBack;
    }

    public void Expansion(){
        size = new Vector3(size.x + expansion,
                           size.y + expansion,
                           size.z + expansion);
        count++;
        if (count >= 10){
            
            size = originSiza;
            count = 0;
            gameController.Bonus();
        }
        this.transform.localScale = size;
    }
}
