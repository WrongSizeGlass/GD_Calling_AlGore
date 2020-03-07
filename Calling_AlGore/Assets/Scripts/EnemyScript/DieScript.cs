using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{

    public int HP = 2;
    // Start is called before the first frame update
    public void TakeDamage(int damage){
       
        HP -= damage;
        Debug.Log("damage by " + damage + " current health = " + HP);
        if (HP <=0){
            die();
        }
    }
    
    void die(){
        Destroy(gameObject);
    }
}
