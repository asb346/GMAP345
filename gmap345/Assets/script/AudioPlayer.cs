using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {

	void Awake ()
    {
    	GameObject[] objs = GameObject.FindGameObjectsWithTag("Audio Source");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
 }
