using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothTime = 0.3f;
    public float maxSpeed = 0.3f;

    private bool move = true;
    private Vector3 formerposition;
    private Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 goal;
        if (move)
        {
            goal = target.position;
            goal.z = transform.position.z;
            formerposition = transform.position;
            transform.position = Vector3.SmoothDamp(transform.position, goal, ref velocity, smoothTime, maxSpeed, Time.deltaTime);
        }
        else
        {
            velocity = Vector3.zero;
            transform.position = formerposition;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        move = false;
    }
    void OnCollisionExit(Collision collision)
    {
        move = true;
    }

}
