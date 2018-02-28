using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

    public Transform target;
    public float speed = 2f;
    public float thresholdDistance = 1000;
    private float range;
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range < thresholdDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
