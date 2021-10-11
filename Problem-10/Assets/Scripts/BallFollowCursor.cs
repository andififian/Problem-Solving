using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowCursor : MonoBehaviour
{
    private Rigidbody2D ballRigidbody;
    public Camera mainCamera;
    [Header("Ball Movement")]
    public Vector2 ballpos = new Vector2(100, 100);
    public float speed;
    public ScoreController scoreController;

     private void Start(){
        ballRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Update(){
        Vector3 target = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 moveAngle = target - transform.position;

        if (Vector3.Distance(target, transform.position) > 0.5)
            transform.Translate(moveAngle.normalized * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Box")
        {
            scoreController.IncreaseCurrentScore(1);
            Destroy(collision.gameObject);
        }
    }
}