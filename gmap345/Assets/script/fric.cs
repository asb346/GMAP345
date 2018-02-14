using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fric : MonoBehaviour {
    public float friction;
    public Rigidbody2D rig;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rig.AddForce(rig.velocity * friction * -1);
    }
}
