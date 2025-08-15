using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMover2 : MonoBehaviour
{
    //moves brick row to the left
    //this is just BrickMover but in the opposite direction
    public float speed = 1f;
    public float distance = 2f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float move = distance - Mathf.PingPong(Time.time * speed, distance * 2);
        transform.position = new Vector3(startPos.x + move - distance, transform.position.y, transform.position.z);
    }
}
