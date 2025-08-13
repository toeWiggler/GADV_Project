using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMover : MonoBehaviour
{
    public float speed = 1f;          // Speed of movement
    public float distance = 2f;       // How far left and right it moves from the start position

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        transform.position = new Vector3(startPos.x + x, transform.position.y, transform.position.z);
    }
}
