using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverGM : MonoBehaviour {

    public Button restartButton;
    public Button exitButton;

    // Use this for initialization
    void Start () {
        restartButton.onClick.AddListener(restartgame);
        exitButton.onClick.AddListener(exitgame);
    }

    void restartgame()
    {
        SceneManager.LoadScene("int", LoadSceneMode.Single);
    }
    void exitgame()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
