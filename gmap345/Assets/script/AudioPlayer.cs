using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {

	void Awake ()
    {
    	GameObject[] objs = GameObject.FindGameObjectsWithTag("audio");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }
 }
