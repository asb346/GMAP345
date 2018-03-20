using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToVictory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("wait");
	}

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("win", LoadSceneMode.Single);
        Destroy(GameObject.FindGameObjectWithTag("player"));
    }
}
