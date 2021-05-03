using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private AudioSource wav;
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    
    
    
    public bool isdead = false;
    private Animator animator;
    private float spawny;
    //public GameObject prefab;
    
    void Start()
    {
        
        wav = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
        
    }


    private void Update()
    {
        if (!(isdead) && Input.GetMouseButtonDown(0))
        {
            //flap.Play();
            wav.Play();
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 200));
            animator.SetTrigger("fly_2");
            
            
        }

        
    }
    void spawncolumn()
    {
        spawny = Random.Range(-1.54f, 3.42f);
        //Instantiate(prefab, new Vector2(4f, spawny), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //changing  gravity stuff
        rb.mass = 5;
        rb.gravityScale = 0.09f;
        //rb.velocity = new Vector2(0, -0.5f);

        //actual work
        isdead = true;
        game_controls.instance.bird_died();
        animator.SetTrigger("dead");
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;

        if (collision.gameObject.tag == "Respawn")
        {
            spawncolumn();
        }

        

    }



}
