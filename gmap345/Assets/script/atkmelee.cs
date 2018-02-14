using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkmelee : MonoBehaviour {
    private float cd;
    public float atkspd;
    public GameObject p;
    private Transform player;
    // Use this for initialization
    void Start(){
        cd = 0;
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()    {
        if (Input.GetMouseButtonDown(0) && Time.time > cd)
        {
            cd = Time.time + atkspd;
            atk();
        }
    }
    private void atk()
    {
        Instantiate(p, player.position, player.rotation);
    }
}
