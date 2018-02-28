using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projs : MonoBehaviour {
    private Rigidbody2D rig;
    public float speed;
    public int damage;
    public float eff;
    public void Start()
    {
        
        rig = GetComponent<Rigidbody2D>();
        rig.velocity= new Vector2(-1*speed * Mathf.Sin(Mathf.Deg2Rad*rig.transform.rotation.eulerAngles.z), speed * Mathf.Cos(Mathf.Deg2Rad*rig.transform.rotation.eulerAngles.z));

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("level")) {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (collision.gameObject.GetComponents<ustat>().Length > 0) {
                collision.gameObject.GetComponent<ustat>().damage(damage);
            }
            collision.GetComponent<Rigidbody2D>().AddForce(GetComponent<Rigidbody2D>().velocity*eff);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("box"))
        {
            collision.GetComponent<Rigidbody2D>().AddForce(GetComponent<Rigidbody2D>().velocity * eff);
            Destroy(this.gameObject);
        }
    }

    public void FixedUpdate()
    {
      
    }
}
