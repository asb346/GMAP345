using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerchar : MonoBehaviour {
    public float speed;
    private Rigidbody2D rig;

    public float jumpforce;
    public float jumpcd;
    private float jumpc = 0;
    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody2D>();  
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 vec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rig.AddForce(vec * speed);

        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        float AngleRad = Mathf.Atan2(p.x - rig.position.x, p.y - rig.position.y);
        AngleRad *= -1;
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

        if (Input.GetKey(KeyCode.Space))
        {
            if (jumpc <= 0)
            {
                rig.AddForce(transform.rotation*new Vector2(0,jumpforce));
                jumpc = jumpcd;
            }
        }
        jumpc -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("enemy"))
            Destroy(this.gameObject);
    }
}
