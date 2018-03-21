using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CreditGM : MonoBehaviour {

    public Button exitButton;

    // Use this for initialization
    void Start () {
        exitButton.onClick.AddListener(toMainMenu);
    }

    void toMainMenu()
    {
        SceneManager.LoadScene("title", LoadSceneMode.Single);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
