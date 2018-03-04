using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class room : MonoBehaviour {
    [SerializeField] string nextscene;
    public Vector3 newpos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("triggered");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("player"))
        {
            DontDestroyOnLoad(collision.gameObject);
            DontDestroyOnLoad(GameObject.FindGameObjectWithTag("MainCamera"));
            collision.transform.position=newpos;
            SceneManager.LoadScene(nextscene);
        }   
 
    }
}
