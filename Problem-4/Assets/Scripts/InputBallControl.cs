using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBallControl : MonoBehaviour
{
private ContactPoint2D lastContactPoint;
    
    public KeyCode buttonup = KeyCode.UpArrow;
    public KeyCode buttonleft = KeyCode.LeftArrow;
    public KeyCode buttonright = KeyCode.RightArrow;
    public KeyCode buttondown = KeyCode.DownArrow;
    public float speed = 10.0f;
    public float yBoundary = 0.0f;
    
    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        
        if (Input.GetKey(buttonup)){
            velocity.y = speed;
        }
        else if (Input.GetKey(buttondown)){
            velocity.y = -speed;
        }
        else if (Input.GetKey(buttonleft)){
            velocity.x = -speed;
        }
        else if (Input.GetKey(buttonright)){
            velocity.x = speed;
        }
        else{
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
        rigidBody2D.velocity = velocity;
        Vector3 position = transform.position;
        if (position.y > yBoundary){
            position.y = yBoundary;
        }
        else if (position.y < -yBoundary){
            position.y = -yBoundary;
        }
        transform.position = position;
    }
}