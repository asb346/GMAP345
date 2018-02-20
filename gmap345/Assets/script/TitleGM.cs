using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleGM : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("game", LoadSceneMode.Single);
            print("You hit space");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("help", LoadSceneMode.Single);
            print("You hit h");
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("title", LoadSceneMode.Single);
            print("You hit backspace");
        }
    }
}
