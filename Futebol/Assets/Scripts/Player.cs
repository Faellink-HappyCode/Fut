using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    Camera cam;
    Transform my;
    bool mouseOver;
    
    private GameObject GameController;
    private Rigidbody2D rb2dBlue, rb2dRed;

    public float speed;
    
    void Awake()
    {
        cam = Camera.main;
        my = this.gameObject.GetComponent<Transform>();
        GameController = GameObject.Find("GameController");
    }

    
    // Start is called before the first frame update
    void Start()
    {
        CheckPlayerTeam();
        mouseOver = false;
        GameController.GetComponent<GameController>().RedTurn = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0) && mouseOver)
        {
            mouseOver = false;
            speed = 500;
            AddForce();
        }

        if (Input.GetKeyUp(KeyCode.Mouse1) && mouseOver)
        {
            mouseOver = false;
            speed = 500;
            AddForce();
        }

        RotateObjectByMousePos();
    }
    
    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1)){
            mouseOver = true;
        }
    }
    
    void AddForce()
    {
        if(this.gameObject.tag == "p1" && !GameController.GetComponent<GameController>().RedTurn)
        {
            rb2dBlue.AddForce(transform.right * speed);
        }
        else if (this.gameObject.tag == "p2" && GameController.GetComponent<GameController>().RedTurn)
        {
            rb2dRed.AddForce(transform.right * speed);
        }
    }
    
    void CheckPlayerTeam()
    {
        if(this.gameObject.tag == "p1")
        {
            rb2dBlue = this.gameObject.GetComponent<Rigidbody2D>();
        }
        else if(this.gameObject.tag == "p2")
        {
            rb2dRed = this.gameObject.GetComponent<Rigidbody2D>();
        }
    }
    
    void RotateObjectByMousePos()
    {
        if(GameController.GetComponent<GameController>().RedTurn && this.gameObject.tag == "p2")
        {
            if (mouseOver)
            {
                float camDistance = cam.transform.position.y - my.position.y;
                Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDistance));
                float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
                float angle = (180 / Mathf.PI) * AngleRad;
                rb2dRed.rotation = angle;

            }
        }

        if (!GameController.GetComponent<GameController>().RedTurn && this.gameObject.tag == "p1")
        {
            if (mouseOver)
            {
                float camDistance = cam.transform.position.y - my.position.y;
                Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDistance));
                float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
                float angle = (180 / Mathf.PI) * AngleRad;
                rb2dBlue.rotation = angle;

            }
        }
    }
}
