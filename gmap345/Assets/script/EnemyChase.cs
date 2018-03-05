﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

    public GameObject target;
    public float speed = 2f;
    public float thresholdDistance = 1000;
    private float range;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("player");
    }
    void Update()
    {
        range = Vector2.Distance(transform.position, target.transform.position);

        if (range < thresholdDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
