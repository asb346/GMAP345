using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deatheff : MonoBehaviour {
    public float delay;
	// Use this for initialization
	void Start () {
        StartCoroutine("destroy");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private IEnumerator destroy()
    {
        yield return new WaitForSeconds(delay);
        Destroy(this.gameObject);
    }
}
