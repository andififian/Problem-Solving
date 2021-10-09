using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowCursor : MonoBehaviour
{
    public void Update(){
        Vector2 PosCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(PosCursor.x, PosCursor.y);
    }
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
