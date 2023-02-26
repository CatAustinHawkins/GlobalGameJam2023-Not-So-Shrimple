using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;

    public Vector3 position;
    public bool goingup = true;
    public bool goingsideways;

    void Update()
    {
        if(goingup)
        {
            Vector3 position = transform.position;
            position.y = (player.transform.position + offset).y;
            transform.position = position;
        }
    
        if(goingsideways)
        {
            position = transform.position;
            position.x = (player.transform.position + offset).x;
            transform.position = position;
        }
    }

    public void GoingSideways()
    {
        goingsideways = true;
        goingup = false;
    }
    public void GoingUp()
    {
        goingsideways = false;
        goingup = true;
    }
}
