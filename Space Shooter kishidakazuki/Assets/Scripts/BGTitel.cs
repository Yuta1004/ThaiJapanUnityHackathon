using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGTitel : MonoBehaviour
{

    public float tileSizeZ;
    public float scrollSpeedTitel;
    private Vector3 startPosition;

    void Start(){

        startPosition = transform.position;
    }

    void Update(){
        float newPosition = Mathf.Repeat(Time.time * scrollSpeedTitel, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
