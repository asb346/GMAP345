using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewalltrigger : MonoBehaviour {
    public GameObject hit;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("player"))
        {
            if (hit.gameObject.GetComponents<movewall>().Length > 0)
            {
                hit.SetActive(true);
                hit.GetComponent<movewall>().act();
            }
        }

    }
}
