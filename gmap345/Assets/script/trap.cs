using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
    public GameObject hit;
    public bool onetime;
    // Use this for initialization
    void Start () {
        hit.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("player"))
        {
            if (hit.gameObject.GetComponents<traphit>().Length > 0) {
                hit.SetActive(true);
                hit.GetComponent<traphit>().act();
            }
            if (onetime) {
                Destroy(this.gameObject);
            }
        }

    }
}
