using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{       
    //I'm going to need some variables for later, that tell me about position
    public Vector3 myStartPosition = new Vector3(0f, 0f, 0f);
    public Vector3 myEndPosition = new Vector3(0f, 0f, 0f);
    public int speed = 3;
    public bool forward = true;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = myStartPosition;
    }

    // Update is called once per frame
    void Update()
    {    
        //if we reach the end, then change our direction boolean to go backward 
       if (gameObject.transform.position.z >=myEndPosition.z)
       {
            forward = false;
       }
        //if we reach the begining then change our direction to go forward 
        if (gameObject.transform.position.z >= myEndPosition.z)
        {
            forward = true;
        }

        //if we are going backward then add the speed 
        
        
        if (forward == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + (Time.deltaTime * speed));
        }
        //If we are going backward then subtract the speed

        if (forward == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - (Time.deltaTime * speed));
        }
    }
}
