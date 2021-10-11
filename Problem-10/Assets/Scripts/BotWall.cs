using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotWall : MonoBehaviour
{
    public PlayerControl player;
    void OnTriggerEnter2D(Collider2D anotherCollider)
    {
        // Jika objek tersebut bernama "Ball":
        if (anotherCollider.name == "Ball")
        {
                // ...restart game setelah bola mengenai dinding.
                anotherCollider.gameObject.SendMessage("RestartGame", 2.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
