using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewall : MonoBehaviour {
    public float movetime;
    public float backtime;
    public Vector3 targetpos;
    private Rigidbody2D rig;
    private Vector3 startpos;
    private Vector3 target;
    public float distance;
    public bool startmove;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>();
        distance = Vector3.Distance(startpos, targetpos + transform.position);
        target = targetpos + transform.position;
        startmove = false;
        startpos = transform.position;
	}
    public void act() {
            startmove = true;
    }
	// Update is called once per frame
	void FixedUpdate () {
        if (Vector3.Distance(transform.position, target) < 0.1)
        {
            startmove = false;
        }
        if (startmove)
        {
            {
                float mov = distance / movetime * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target, mov);
            }

        }
        else {
                float mov = distance / backtime * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, startpos, mov);
        }
	}

}
