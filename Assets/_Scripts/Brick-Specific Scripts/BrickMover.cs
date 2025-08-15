using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMover : MonoBehaviour
{
    //moves brick row to the right
    public float speed = 1f; // speed of movement
    public float distance = 2f; // how far it moves from start

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; //where it starts
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, distance * 2) - distance; //pingpong makes it move back and forth around the original position
        transform.position = new Vector3(startPos.x + move, transform.position.y, transform.position.z); //moving it on the x-axis
    }
}
