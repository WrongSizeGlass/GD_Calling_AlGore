using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();


        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2, 0);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {

            rb2d.velocity = new Vector2(-2, 0);
        }
        else if (Input.GetKey("space") || Input.GetKey("up"))
        {

            rb2d.velocity = new Vector2(0, 4);
        }
    }

}
