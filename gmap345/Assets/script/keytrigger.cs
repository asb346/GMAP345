using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keytrigger : MonoBehaviour {
    public string key;
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
            if (collision.gameObject.GetComponents<keys>().Length > 0)
            {
                collision.gameObject.GetComponent<keys>().k.Add(key);
            }
            Destroy(this.gameObject);
        }
    }
}
