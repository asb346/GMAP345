using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projs : MonoBehaviour {
    private Rigidbody2D rig;
    public float speed;
    public int damage;
    public float eff;
    public float travel;

    public void Start()
    {
        StartCoroutine("destroy");
        rig = GetComponent<Rigidbody2D>();
        rig.velocity= new Vector2(-1*speed * Mathf.Sin(Mathf.Deg2Rad*rig.transform.rotation.eulerAngles.z), speed * Mathf.Cos(Mathf.Deg2Rad*rig.transform.rotation.eulerAngles.z));

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("box")) {
            
            Destroy(this.gameObject);

        }
      
        if (collision.gameObject.CompareTag("enemy"))
        {

            collision.GetComponent<Rigidbody2D>().AddForce(GetComponent<Rigidbody2D>().velocity*eff);
            Destroy(this.gameObject);
        }

    }
    private IEnumerator destroy()
    {
        yield return new WaitForSeconds(travel);
        Destroy(this.gameObject);
    }
    public void FixedUpdate()
    {
      
    }
}
