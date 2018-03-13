using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRLStrafe : MonoBehaviour {

    public float speed = 2f;
    public Vector2 direction = Vector2.left;

    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = transform.GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (direction == Vector2.left)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.left;
        }
    }

}
