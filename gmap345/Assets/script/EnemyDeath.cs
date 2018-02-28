using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D c)
    {
        if (!c.gameObject.CompareTag("map"))
            Destroy(this.gameObject);
    }
}
