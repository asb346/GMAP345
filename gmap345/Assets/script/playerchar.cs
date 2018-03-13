using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerchar : MonoBehaviour {
    public float speed;
    private Rigidbody2D rig;
    public GameObject spr;
    /*
    public float jumpforce;
    public float jumpcd;
    private float jumpc = 0;
    */
    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody2D>();  
	}

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rig.AddForce(vec * speed);
        if (spr.transform.rotation.eulerAngles.z > 180)
        {

            GetComponent<SpriteRenderer>().flipY = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            if (jumpc <= 0)
            {
                rig.AddForce(transform.rotation*new Vector2(0,jumpforce));
                jumpc = jumpcd;
            }
        }
        */
        //jumpc -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("gameover");
        }
    }
}
