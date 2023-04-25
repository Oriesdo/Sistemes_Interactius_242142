using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{

    public float speed = 2f;

    private Rigidbody rb;
    private Vector3 movement;
    private int movementX;
    private int movementY;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        System.Random rnd = new System.Random();
        movementX = rnd.Next(-3,3);
        movementY = rnd.Next(-3,3);
        movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}