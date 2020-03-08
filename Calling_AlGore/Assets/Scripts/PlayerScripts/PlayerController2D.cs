using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Transform groundCheck;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {   
        // Check to see if character is on the ground
        if (Physics2D.Linecast(transform.position, groundCheck.position, 
            1 << LayerMask.NameToLayer("Ground"))) {
            isGrounded = true;
        }
        else {
            isGrounded = false;
        }

        // Basic player movement based on input
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb2d.velocity = new Vector2(2, rb2d.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left")) {
            rb2d.velocity = new Vector2(-2, rb2d.velocity.y);
        }
        // Stop if not going right or left
        else {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        // Jumping
        if (Input.GetKey("space") && isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 4);
        }
    }

}
