using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public static float speed;
    private Rigidbody rb;

    void Start(){
        
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        rb.velocity = transform.forward * speed;
    }
}
