using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Vector3 offSet;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        offSet = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        constrainCamera();
    }

    void constrainCamera (){
        float newXPos = player.transform.position.x - offSet.x;
        float newYPos = player.transform.position.y - offSet.y;

        transform.position = new Vector3(newXPos, newYPos, transform.position.z);
    }
}
