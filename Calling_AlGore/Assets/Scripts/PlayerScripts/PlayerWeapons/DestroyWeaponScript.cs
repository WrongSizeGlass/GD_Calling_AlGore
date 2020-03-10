using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWeaponScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefrab;
    destroyBulletScript a;
    float time;
    float timer;
    bool timerStarted;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.0f;
        timerStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1") && timerStarted){
            shoot();
            
        }
        
        if(timerStarted){
            time += Time.deltaTime;
            if(time > timer){
                shoot();
                
            }
        }
        
        

        if(Input.GetButtonDown("Fire1")){
            timerStarted = true;
        }
        
    }

    void shoot(){

        a = bulletPrefrab.GetComponent<destroyBulletScript>();
        a.force = 3.0f + (time * 10.0f);
        Instantiate(bulletPrefrab, firePoint.position, firePoint.rotation);
        Debug.Log(a.force);
        time = 0;
        timerStarted = false;

    }

}
