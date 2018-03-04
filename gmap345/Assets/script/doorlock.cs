using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour {
    public string key;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("player"))
        {
            if (collision.gameObject.GetComponents<keys>().Length > 0)
            {
                if (collision.gameObject.GetComponent<keys>().k.Contains(key)) {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
