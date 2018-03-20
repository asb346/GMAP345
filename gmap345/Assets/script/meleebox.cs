using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleebox : MonoBehaviour {
    private Rigidbody2D rig;
    private AudioSource audioSource;
    public float duration;
    public float offset;
    public int damage;
    public float eff;
    private float t;

    // Use this for initialization
    public void Start()
    {
        duration += Time.time;
        rig = GetComponent<Rigidbody2D>();
        rig.transform.Translate(0,offset, 0);
        audioSource = GetComponent<AudioSource>();
    }
    private bool col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        col = true;

        if (collision.gameObject.CompareTag("enemy"))
        {
            if (collision.gameObject.GetComponents<ustat>().Length > 0)
            {
                audioSource.Play();
                collision.gameObject.GetComponent<ustat>().damage(damage);
            }
            collision.GetComponent<Rigidbody2D>().AddForce(GetComponent<Rigidbody2D>().velocity * eff);
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
        if (Time.time > duration)
        {
            Destroy(this.gameObject);
        }
    }
}
