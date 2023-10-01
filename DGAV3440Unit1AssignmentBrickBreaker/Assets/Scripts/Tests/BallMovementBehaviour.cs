using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementBehaviour : MonoBehaviour
{
    public Rigidbody rb;
    public bool inPlay;
    public Transform paddle;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.AddForce(Vector2.up * 500);
    }
    
    void Update()
    {
        if (!inPlay)
        {
            transform.position = paddle.position;
        }
    }
}
