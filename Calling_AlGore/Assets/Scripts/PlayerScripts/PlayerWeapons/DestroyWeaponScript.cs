using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWeaponScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefrab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            shoot();
        }
    }

    void shoot(){

        Instantiate(bulletPrefrab, firePoint.position, firePoint.rotation);

    }

}
