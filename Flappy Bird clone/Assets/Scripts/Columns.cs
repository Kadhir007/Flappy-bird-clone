using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour
{
    private Rigidbody2D rb;
    public Color c;
    public GameObject g1, g2, g3, g4, g5, g6;
    public GameObject prefab;
    private float spawny;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-2f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (game_controls.instance.endgame== true)
        {
            rb.velocity = Vector2.zero;

            //changing color
            //changing color of Bg
            g1.GetComponent<SpriteRenderer>().color = c;
            g2.GetComponent<SpriteRenderer>().color = c;
            g3.GetComponent<SpriteRenderer>().color = c;
            g4.GetComponent<SpriteRenderer>().color = c;
            g5.GetComponent<SpriteRenderer>().color = c;
            g6.GetComponent<SpriteRenderer>().color = c;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<bird>() != null)
        {
            spawny = Random.Range(-2.11f, 2.5f); 
            game_controls.instance.birdscore();
            Instantiate(prefab, new Vector2(-0.5f, spawny), Quaternion.identity);
            
        }

        
        
    }
}
