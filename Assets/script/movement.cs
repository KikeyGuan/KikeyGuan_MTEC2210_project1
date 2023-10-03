using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class movement : MonoBehaviour
{
    public float speed = 400;
    Rigidbody2D rb;
    float xMove;
    public TextMeshPro playerscoretext;
    int playerscore;
    private AudioSource audioSource;
    public AudioClip bite;
    public AudioClip step;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        playerscoretext.text = playerscore.ToString();
    }
    public void Score(int scoreChnage)
    {
        playerscore += scoreChnage;
    }

    public void Stop(float stopvalue)
    {
        speed = 0;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Time.deltaTime * speed * xMove, 0);
        if (xMove > 0)
        {
            sr.flipX = true;
        }
        if(xMove < 0)
        {
            sr.flipX = false;
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {

            int value = collision.gameObject.GetComponent<droppedcoin>().coinvalue;
            Score(value);
            audioSource.PlayOneShot(bite);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "End"){
            audioSource.PlayOneShot(step);
        }
    }
}
