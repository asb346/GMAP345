using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.gameObject.CompareTag("projectile"))
        {
            Destroy(this.gameObject);
        }
    }
}
