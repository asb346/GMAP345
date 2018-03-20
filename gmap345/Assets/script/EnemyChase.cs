using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

    public GameObject target;
    public float speed = 2f;
    public float thresholdDistance = 1000;
    private float range;
    private bool flag = false;
    public CameraShake camShake;
    private AudioSource audioSource;
    public AudioClip clip_movement;
    public AudioClip clip_death;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("player");
        camShake = FindObjectOfType<CameraShake>();

        /* Audio stuff */
        audioSource = GetComponent<AudioSource>();
        // audioSource.volume = 0.15f;

    }


    void Update()
    {
        if(!flag) {
            range = Vector2.Distance(transform.position, target.transform.position);

            if (range < thresholdDistance)
            {
                if (!audioSource.isPlaying) {
                    audioSource.PlayOneShot(clip_movement);
                }
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            }
        } else {
            if (!audioSource.isPlaying) {
                Destroy(this.gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("wall"))
        {
            audioSource.Stop();
            audioSource.PlayOneShot(clip_death);

            camShake.shakeAmount = .2f;
            Destroy(this.gameObject);
        }
    }
}
