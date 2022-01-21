using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeper : MonoBehaviour
{
    public float delta = 1.5f;
    public float speed = 2.0f;
    public float kickSpeed = 600;

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }


    void KeeperMoves()
    {
        Vector3 v = startPosition;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "ball")
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * kickSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        KeeperMoves();
    }
}
