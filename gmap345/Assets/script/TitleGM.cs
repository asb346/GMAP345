using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class TitleGM : MonoBehaviour {

    public Button startButton;
    public Button helpButton;
    public Button creditsButton;
    public AudioSource audioSource;
    public float  finalVolume;

	// Use this for initialization
	void Start () {
        startButton.onClick.AddListener(startgame);
        helpButton.onClick.AddListener(loadhelp);
	}


    void startgame()
    {
        audioSource.volume = finalVolume;
        SceneManager.LoadScene("int", LoadSceneMode.Single);
    }

    void loadhelp()
    {
        SceneManager.LoadScene("help", LoadSceneMode.Single);
    }


	// Update is called once per frame
	void Update () {
    }
}
