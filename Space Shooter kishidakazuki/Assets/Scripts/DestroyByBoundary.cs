using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    private PlayerController playerController;

	void Start(){
        GameObject playerControllerObject = GameObject.FindWithTag("Player");
        if (playerControllerObject != null){

            playerController = playerControllerObject.GetComponent<PlayerController>();
        }
        if (playerController == null){

            Debug.Log("Cannot find 'PlayerController' script");
        }
	}
	void OnTriggerExit(Collider other){

        playerController.UpdateHP(2);
        Destroy(other.gameObject);
    }
}
