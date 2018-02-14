using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyleft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level"))
        {
            GetComponent<Transform>().parent.GetComponent<enemypath>().leftb();


        }
        if (collision.gameObject.CompareTag("playerchar"))
        {

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("level"))
        {
            GetComponent<Transform>().parent.GetComponent<enemypath>().leftc();

        }
    }
}
