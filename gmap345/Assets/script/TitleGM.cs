﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class TitleGM : MonoBehaviour {

    public Button startButton;
    public Button helpButton;
    public Button creditsButton;
    public Button quitButton;
    public AudioSource audioSource;
    public AudioClip newClip;
    public float  finalVolume;

	// Use this for initialization
	void Start () {
        audioSource = AudioSource.FindObjectOfType<AudioSource>();
        startButton.onClick.AddListener(startgame);
        helpButton.onClick.AddListener(loadhelp);
        creditsButton.onClick.AddListener(credits);
        quitButton.onClick.AddListener(totalquit);
	}


    void startgame()
    {
        audioSource.volume = finalVolume;
        audioSource.clip = newClip;
        audioSource.Stop();
        audioSource.Play();
        audioSource.loop = true;
        SceneManager.LoadScene("int", LoadSceneMode.Single);
    }

    void loadhelp()
    {
        SceneManager.LoadScene("help", LoadSceneMode.Single);
    }

    void credits()
    {
        SceneManager.LoadScene("credits", LoadSceneMode.Single);
    }

    void totalquit()
    {
        Application.Quit();
    }


	// Update is called once per frame
	void Update () {
    }
}
