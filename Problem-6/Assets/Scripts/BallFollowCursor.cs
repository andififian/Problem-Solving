using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowCursor : MonoBehaviour
{
    private Rigidbody2D ballRigidbody;
    public void Update(){
        Vector2 PosCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(PosCursor.x, PosCursor.y);
    }
    private void Start(){
        ballRigidbody = GetComponent<Rigidbody2D>();
    }
}
