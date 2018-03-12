using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projpick : MonoBehaviour {
    public GameObject proj;
    public float attackspeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("player"))
        {
            if (collision.gameObject.GetComponents<patk1>().Length > 0)
            {
               
            }
            else {
                collision.gameObject.AddComponent<patk1>();
                var p = collision.GetComponent<patk1>();
                p.p = proj;
                p.atkspd = attackspeed;
            }
            Destroy(this.gameObject);
        }
    }
}
