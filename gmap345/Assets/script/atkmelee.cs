using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkmelee : MonoBehaviour {
    private float cd;
    public float atkspd;
    public GameObject p;
    public float delay;
    private float delayc;
    private Transform player;
    // Use this for initialization
    void Start(){
        cd = 0;
        delayc = -3;
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()    {
        if (Input.GetMouseButtonDown(0) && Time.time > cd)
        {
            cd = Time.time + atkspd;
            delayc = delay;
        }
        if (delayc < 0 && delayc> -2)
        {
            atk();
            delayc -= 2;
        }
        if (delayc >= 0) {
            delayc -= Time.deltaTime;
        }
    }
    private void atk()
    {
        var t = Instantiate(p, player.position, player.rotation);
        t.transform.parent = gameObject.transform;
    }

}
