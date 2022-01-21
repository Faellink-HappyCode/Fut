using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    
    public GameObject ball;
    public GameObject gc; //gamecontroller
    private Vector3 ballPosition = new Vector3(0, 0, -1);

    public GameObject blue1, blue2, blue3, blue4, blue5, blue6;
    public GameObject red1, red2, red3, red4, red5, red6;
    public Text blueScore, redScore;

    public bool isRed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void RestartBall()
    {
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody2D>().angularVelocity = 0;
        ball.transform.position = ballPosition;
    }
    
    void RestartPlayers()
    {
        blue1.transform.position = new Vector3(-7.5f, 3.3f, -1);
        blue2.transform.position = new Vector3(-7.5f, -3.11f, -1);
        blue3.transform.position = new Vector3(-4.7f, 0.34f, -1);
        blue4.transform.position = new Vector3(-5.3f, -5.7f, -1);
        blue5.transform.position = new Vector3(-5.3f, 5.75f, -1);
        blue6.transform.position = new Vector3(-1.7f, 0.22f, -1);


        red1.transform.position = new Vector3(1.65f, 0.2f, -1);
        red2.transform.position = new Vector3(7.2f, -3.4f, -1);
        red3.transform.position = new Vector3(7.2f, 3.3f, -1);
        red4.transform.position = new Vector3(4.75f, 0.05f, -1);
        red5.transform.position = new Vector3(4.7f, -5.65f, -1);
        red6.transform.position = new Vector3(4.7f, 5.8f, -1);
    }
    
    
    void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.gameObject.tag =="ball" && isRed)
        {
            gc.GetComponent<GameController>().scoreBlue++;
            gc.GetComponent<GameController>().RedTurn = true;
            RestartBall();
            RestartPlayers();
        }

        if (coll.gameObject.tag == "ball" && !isRed)
        {
            gc.GetComponent<GameController>().scoreRed++;
            gc.GetComponent<GameController>().RedTurn = false;
            RestartBall();
            RestartPlayers();
        }
    }
}
