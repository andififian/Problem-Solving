using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlUpDown : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float xInitialForce;
    public float yInitialForce;
    public ScoreController scoreController;
    public float dorongspeed = 50;
    void ResetBall(){
        // Reset posisi menjadi (0,0)
        transform.position = Vector2.zero;
        // Reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }
    void PushBall(){
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);
        // float xInitialForce = Mathf.Sqrt(dorongspeed * dorongspeed - yRandomInitialForce * yRandomInitialForce);
        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f){
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else{
            rigidBody2D.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }
    void RestartGame(){
        // Kembalikan bola ke posisi semula
        ResetBall();
 
        // Setelah 2 detik, berikan gaya ke bola
        Invoke("PushBall", 2);
    }
    // Start is called before the first frame update
    void Start(){
        rigidBody2D = GetComponent<Rigidbody2D>();

        // Mulai game
        RestartGame();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Box")
        {
            scoreController.IncreaseCurrentScore(1);
            Destroy(collision.gameObject);
        }
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}

