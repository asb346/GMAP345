using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeatheff : MonoBehaviour {
    public GameObject p;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDestroy()
    {
        Instantiate(p, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
    }
}
