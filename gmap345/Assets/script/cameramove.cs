using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {
    public GameObject player;
    public GameObject level;
    private float size;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        /*
        float x = player.GetComponent<Transform>().position.x;
        float y = player.GetComponent<Transform>().position.y;
        GetComponent<Transform>().position.Set(x,y,GetComponent<Transform>().position.z);
        offset = transform.position - player.transform.position;
        */
        offset = new Vector3(0, 0,-50);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}
