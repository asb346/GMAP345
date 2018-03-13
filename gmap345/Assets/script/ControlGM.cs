using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ControlGM : MonoBehaviour {

    public Button backButton;

    // Use this for initialization
    void Start () {
        backButton.onClick.AddListener(maintitle);
    }

    void maintitle()
    {
        SceneManager.LoadScene("title", LoadSceneMode.Single);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
