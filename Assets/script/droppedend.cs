using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedend : MonoBehaviour
{
    public float stopvalue = 0;
    public float endspeed;
    private AudioSource audioSource;
    public AudioClip step;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, endspeed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            endspeed = 0;
            collision.gameObject.GetComponent<movement>().Stop(stopvalue);
            audioSource.PlayOneShot(step);
            Debug.Log("end game");
        }
        if (collision.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }
    }

}
