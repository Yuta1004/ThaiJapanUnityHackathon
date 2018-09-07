using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour{
    
    public float tileSizeZ;
    public static float scrollSpeed;
    private Vector3 startPosition;

    void Start(){
        
        startPosition = transform.position;
    }

    void Update(){
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
