using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedcoin : MonoBehaviour
{
    public int coinvalue = 1;
    public float coinspeed = .1f;
    public SpriteRenderer sr;
    private AudioSource audioSource;
    public AudioClip bite;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<movement>().Score(coinvalue);
            audioSource.PlayOneShot(bite);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, (Random.Range(-5, -8)) * Time.deltaTime, 0);
    }
}
