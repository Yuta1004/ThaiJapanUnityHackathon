using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWaste : MonoBehaviour {

    public int scoreValue;
    private GameController gameController;

    void Start(){

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null){

            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null){

            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other){

        if (other.tag == "Player"){

            gameController.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
