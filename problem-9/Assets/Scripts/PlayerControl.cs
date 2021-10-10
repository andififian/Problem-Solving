using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
    public float speed = 10.0f;
    public float xBoundary = 9.0f;
    private Rigidbody2D rigidBody2D;
    
    // private int score;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
        else
        {
            velocity.x = 0.0f;
        }
        rigidBody2D.velocity = velocity;
        Vector3 position = transform.position;

        if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }
        transform.position = position;
    }
}
