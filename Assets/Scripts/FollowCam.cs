using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
   // public Transform followTransform;
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public float yHeight;
    public float yPrevious;
    



    /*void FixedUpdate() 
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
        
    }*/
    void Start() 
    {   
    // Takes the player's y axis value and stores it as a minimum height value at the start
       yHeight = GameObject.Find("Player").transform.position.y;
    }
 


    void Update()
    {   

    // every frame checks the player's height currently vs the previous and if higher then runs the camera follow segment to keep up with the player
        yHeight = GameObject.Find("Player").transform.position.y;       
        if(yHeight > yPrevious == true)
            {   
                this.transform.position = new Vector3(target.position.x, target.position.y, target.position.z -10);
                yPrevious = yHeight;      
            }
}
}



