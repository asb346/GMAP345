using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traphitp : MonoBehaviour
{
    public float delay;
    public float count;
    public float cd;
    private bool cdb;
    public GameObject trapbox;
    // Use this for initialization
    void Start()
    {
        cdb = true;
    }
    public void act()
    {
        if (cdb)
        {
            StartCoroutine("traphit");
            StartCoroutine("trapcd");
            cdb = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator traphit()
    {
        yield return new WaitForSeconds(delay);
        var t = Instantiate(trapbox, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
        t.transform.parent = gameObject.transform;
        t.GetComponent<traphit>().count = count;
    }
    private IEnumerator trapcd()
    {
        yield return new WaitForSeconds(cd);
        cdb = true;
    }
}
