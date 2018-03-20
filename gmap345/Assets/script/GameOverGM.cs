using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverGM : MonoBehaviour {

    public Button restartButton;
    public Button exitButton;
    public AudioSource music;
    public AudioClip newClip;

    // Use this for initialization
    void Start () {
        restartButton.onClick.AddListener(restartgame);
        exitButton.onClick.AddListener(exitgame);
        music.Stop();
        music.loop = false;
        music.clip = newClip;
        music.Play();
    }

    void restartgame()
    {
        music.Stop();
        SceneManager.LoadScene("int", LoadSceneMode.Single);
    }
    void exitgame()
    {
        music.Stop();
        Application.Quit();
    }

	// Update is called once per frame
	void Update () {

	}
}
