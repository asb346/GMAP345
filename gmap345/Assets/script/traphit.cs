using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traphit : MonoBehaviour {
    public float count;

	// Use this for initialization
	void Start () {
        StartCoroutine("destroy");
    }
	
	// Update is called once per frame
	void Update () {

	}
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(collision.gameObject);
        }

    }
    private IEnumerator destroy() {
        yield return new WaitForSeconds(count);
        Destroy(this.gameObject);
    }

}
