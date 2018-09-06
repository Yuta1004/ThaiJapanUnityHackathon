using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWaste : MonoBehaviour {

    public int scoreValue;
    private GameController gameController;
    private Replacement replacement;

    void Start(){

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null){

            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null){

            Debug.Log("Cannot find 'GameController' script");
        }

        GameObject garbageBagObject = GameObject.FindWithTag("GarbageBag");
        if (garbageBagObject != null){

            replacement = garbageBagObject.GetComponent<Replacement>();
        }
        if (replacement == null){

            Debug.Log("Cannot find 'Replacement' script");
        }
    }

    void OnTriggerEnter(Collider other){

        if (other.tag == "Player"){

            gameController.AddScore(scoreValue);
            replacement.Expansion();
            Destroy(gameObject);
        }
    }
}
