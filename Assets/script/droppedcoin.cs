using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedcoin : MonoBehaviour
{
    public int coinvalue = 1;
    public float coinspeed;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, coinspeed * Time.deltaTime, 0);//(x,y,z)
    }
}
