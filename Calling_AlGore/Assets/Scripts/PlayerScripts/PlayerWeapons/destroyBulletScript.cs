using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBulletScript : MonoBehaviour
{
    private int dmg = 1;
    public GameObject buildCube;
    Rigidbody2D rb;
    public float force;
    Vector2 Acceleration;
    Vector2 gravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravity = Physics2D.gravity * rb.gravityScale * Vector2.up;
        Acceleration = new Vector2(force,force);
        rb.velocity = Acceleration;
    }

    void FixedUpdate()
    {

        if(force <= 0)
        {
            Destroy(gameObject);
        }

        rb.AddForce(gravity);
        
        
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
       /* DieScript enemy = hit.GetComponent<DieScript>();
        if(enemy != null){
            enemy.TakeDamage(dmg);
        }
      //  Debug.Log(hit);
        Destroy(gameObject);
        */
       //Vector2 spawnpos = new Vector2(transform.position.x,transform.position.y);

      
            //Vector2 spawnpos = new Vector2(transform.position.x,transform.position.y);
            Instantiate(buildCube,new Vector2(transform.position.x, transform.position.y + 0.5f) , transform.rotation);
            Destroy(gameObject);
        
    }

    // Update is called once per frame
}