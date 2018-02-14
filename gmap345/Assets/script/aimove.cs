using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimove : MonoBehaviour {
    public GameObject player; //player object
    public float speed;
    public bool able;
    private Rigidbody2D rig;
    public bool right;
    public bool left;
    public bool forward;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>();
        right = true;
        left = true;
        forward = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        if (forward)
        {
            aimplayer();
        }
        else {

        }

        Vector2 vec = new Vector2(-1 * speed * Mathf.Sin(Mathf.Deg2Rad * rig.transform.rotation.eulerAngles.z), speed * Mathf.Cos(Mathf.Deg2Rad * rig.transform.rotation.eulerAngles.z));
        rig.AddForce(vec * speed);
    }
    public void blocked() {
        forward = false;
    }
    public void rightb() {
            gameObject.GetComponent<Transform>().Rotate(new Vector3(0, 0, 90));
            right = false;

    }
    public void leftb()
    {

            gameObject.GetComponent<Transform>().Rotate(new Vector3(0, 0, -90));
            left = false;

    }
    public void leftc() {
        aimplayer();
        forward = true;
        left = true;
    }
    public void rightc()
    {
        aimplayer();
        right = true;
        forward = true;
    }
    public void aimplayer() {
        Vector3 p = player.GetComponent<Transform>().position;
        float AngleRad = Mathf.Atan2(p.x - rig.position.x, p.y - rig.position.y);
        AngleRad *= -1;
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }
    public void clear() {
        forward = true;
    }
}
