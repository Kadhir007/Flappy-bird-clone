using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D groundcollider;
    private float horizontal_length;
    // Update is called once per frame
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-3f, 0);
        groundcollider = GetComponent<BoxCollider2D>();
        horizontal_length = groundcollider.size.x;
    }

    
    void Update()
    {
       if (game_controls.instance.endgame == true)
        {
            rb.velocity = Vector2.zero;
        }
       
    }
   
}
