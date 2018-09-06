using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
    public float xMin, xMax, zMin, zMax;
}


public class PlayerController : MonoBehaviour {
    
    public float speed;
    public Boundary boundary;
    public float tilt;
    public float yFix = 0.0f;
    public GameObject RedGarbageBag;
    public GameObject BlueGarbageBag;
    public GameObject GreenGarbageBag;

    private Rigidbody rb;
    private float nextFire;

    void Start(){
        
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = 
            new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 
            yFix,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        //横移動のとき，傾ける
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
