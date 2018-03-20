using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLunge : MonoBehaviour {

    public GameObject target;
    public float speed = 2f;
    public float thresholdDistance = 1000;
    private float range;
    public float lungeDuration = .5f;
    public float waitDuration = .5f;

    public CameraShake camShake;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("player");
        camShake = FindObjectOfType<CameraShake>();
    }
    void Update()
    {
        range = Vector2.Distance(transform.position, target.transform.position);
        if (range < thresholdDistance)
        {
            if (waitDuration > 0)
            {
                waitDuration -= Time.deltaTime;
            }
            else if (lungeDuration > 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                lungeDuration -= Time.deltaTime;
            }
            else
            {
                lungeDuration = .5f;
                waitDuration = .5f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("wall"))
        {
            camShake.shakeAmount = .2f;
            Destroy(this.gameObject);
        }
    }
}
