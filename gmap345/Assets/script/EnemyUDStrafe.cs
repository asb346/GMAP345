using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUDStrafe : MonoBehaviour {

    public float speed = 2f;
    public Vector2 direction = Vector2.up;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (direction == Vector2.up)
        {
            Debug.Log("switch");
            direction = Vector2.down;
        }
        else
        {
            Debug.Log("switch");
            direction = Vector2.up;
        }
    }
}
