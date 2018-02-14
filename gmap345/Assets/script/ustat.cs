using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ustat : MonoBehaviour {
    public int hp;
    public int maxhp;
    // Use this for initialization
    void Start()
    {
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void damage(int d) {
        hp -= d;
        if (hp < 0)
        {
            Destroy(this.gameObject);
        }
    }
}