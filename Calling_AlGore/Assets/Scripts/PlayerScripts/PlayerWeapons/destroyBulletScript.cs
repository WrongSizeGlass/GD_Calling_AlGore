using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBulletScript : MonoBehaviour
{

    private float speed = 5f;
    private int dmg = 1;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        DieScript enemy = hit.GetComponent<DieScript>();
        if(enemy != null){
            enemy.TakeDamage(dmg);
        }
      //  Debug.Log(hit);
        Destroy(gameObject);
    }

    // Update is called once per frame

}
