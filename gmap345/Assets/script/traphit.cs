using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traphit : MonoBehaviour {
    public float delay;
    public float count;
    bool acted;

	// Use this for initialization
	void Start () {
        acted = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
    public void act() {
        StartCoroutine("act2");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("player"))
        {
            if (acted) {
                Destroy(collision.gameObject);
            }
        }

    }
    private IEnumerator destroy() {
        yield return new WaitForSeconds(count);
        Destroy(this.gameObject);
    }
    private IEnumerator act2()
    {
        yield return new WaitForSeconds(delay);
        
        acted = true;
        StartCoroutine("destroy");
    }
}
