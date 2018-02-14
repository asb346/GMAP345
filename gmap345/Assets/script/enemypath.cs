using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypath : MonoBehaviour {
    public bool right;
    public bool left;
    public bool forward;
	// Use this for initialization
	void Start () {
        right = true;
        left = true;
        forward = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void rightb()
    {
        if (right)
        {
            GetComponent<Transform>().parent.GetComponent<aimove>().rightb();
            right = false;
        }
    }
    public void leftb()
    {
        if (left) {
        GetComponent<Transform>().parent.GetComponent<aimove>().leftb();
            left = false;
        }
    }
    public void rightc()
    {
        if (!right)
        {
            GetComponent<Transform>().parent.GetComponent<aimove>().rightc();
            right = true;
        }
    }
    public void leftc()
    {
        if (!left)
        {
            GetComponent<Transform>().parent.GetComponent<aimove>().leftc();
            left = true;
        }
    }
    public void blocked()
    {
        if (!right)
        {
            GetComponent<Transform>().parent.GetComponent<aimove>().rightb();
        } else if (!left) {
            GetComponent<Transform>().parent.GetComponent<aimove>().leftb();
        }
        GetComponent<Transform>().parent.GetComponent<aimove>().blocked();
    }
    public void clear()
    {
        if (left && right)
        {
            GetComponent<Transform>().parent.GetComponent<aimove>().clear();
        }
    }
}
