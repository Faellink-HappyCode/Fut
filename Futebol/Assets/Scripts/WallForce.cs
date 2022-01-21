using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallForce : MonoBehaviour
{
    
    public GameObject ball, gameController;
    private Rigidbody2D rb2d;
    public float speed;
    Vector3 zRot;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = ball.GetComponent<Rigidbody2D>();
        gameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void AddForceToBall()
    {
        if (this.gameObject.tag == "coll_horizontal")
        {
            zRot = new Vector3(0, Random.Range(-1.0f, 1.0f), 0);
            rb2d.AddForce(zRot * speed, ForceMode2D.Impulse);
        }
        else if (this.gameObject.tag == "coll_vertical")
        {
            zRot = new Vector3(Random.Range(-1.0f, 1.0f), 0, 0);
            rb2d.AddForce(zRot * speed, ForceMode2D.Impulse);
        }
    }
    
    void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.gameObject.tag=="ball" && ball.GetComponent<BallTouch>().touchState == 1)
        {
            AddForceToBall();
            gameController.GetComponent<GameController>().RedTurn = true;
        }
        else if (coll.gameObject.tag == "ball" && ball.GetComponent<BallTouch>().touchState == 2)
        {
            AddForceToBall();
            gameController.GetComponent<GameController>().RedTurn = false;
        }
    }

}
