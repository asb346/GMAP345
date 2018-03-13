using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public float speed = 2f;

    private bool move = true;
    private Vector3 formerposition;
    private Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 goal;
        if (move)
        {
            goal = target.transform.position;
            goal.z = transform.position.z;
            formerposition = transform.position;
            transform.GetComponent<Rigidbody2D>().velocity = (goal - transform.position) * speed;
            //Vector3.SmoothDamp(transform.position, goal, ref velocity, smoothTime, maxSpeed, Time.deltaTime);
        }
        else
        {
            velocity = Vector3.zero;
            transform.position = formerposition;
        }
    }

    public void joinplayer()
    {
        transform.position = target.transform.position + new Vector3(0,0,-10);
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
