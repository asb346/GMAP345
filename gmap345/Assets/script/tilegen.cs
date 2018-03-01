using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilegen : MonoBehaviour {
    public GameObject tile;
    public GameObject bg;
    public int width;
    public int height;
    // Use this for initialization
    void Start()
    {
        float w = 6.24f;
        float h = 6.24f;
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var t = Instantiate(tile, new Vector3(x, y, 0), Quaternion.Euler(Vector3.zero));
                t.transform.parent = gameObject.transform;
            }
            for (int y = 1; y < 6; y++)
            {
                var t = Instantiate(bg, new Vector3(x, 0 - y, 0), Quaternion.Euler(Vector3.zero));
                t.transform.parent = gameObject.transform;
                var s = Instantiate(bg, new Vector3(x, y + height-1, 0), Quaternion.Euler(Vector3.zero));
                s.transform.parent = gameObject.transform;
            }
        }
        for (int y = -6; y < height+6; y++)
        {
            for (int x = 1; x < 14; x++)
            {
                var t = Instantiate(bg, new Vector3(0-x, y, 0), Quaternion.Euler(Vector3.zero));
                t.transform.parent = gameObject.transform;
                var s = Instantiate(bg, new Vector3(x+width-1, y, 0), Quaternion.Euler(Vector3.zero));
                s.transform.parent = gameObject.transform;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
