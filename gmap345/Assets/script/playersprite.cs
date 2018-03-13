using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersprite : MonoBehaviour {
    private Rigidbody2D rig;
    // Use this for initialization
    void Start () {
        rig = GetComponentInParent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        float AngleRad = Mathf.Atan2(p.x - rig.position.x, p.y - rig.position.y);
        AngleRad *= -1;
        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

    }

}
