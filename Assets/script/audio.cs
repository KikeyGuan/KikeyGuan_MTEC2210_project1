using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private AudioSource audioScource;
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        audioScource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "object")
        {
            //AudioSource.PlayOneShot("name");
        }
    }
}
