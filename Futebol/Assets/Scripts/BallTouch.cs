using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTouch : MonoBehaviour
{
    
    public int touchState;
    
    // Start is called before the first frame update
    void Start()
    {
        touchState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "p1")
        {
            touchState = 1;
        }

        if (coll.gameObject.tag == "p2")
        {
            touchState = 2;
        }
    }
}
