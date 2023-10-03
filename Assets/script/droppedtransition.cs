using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedtransition : MonoBehaviour
{
    public float stopvalue = 0;
    public float transitspeed;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, transitspeed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<movement>().Stop(stopvalue);
            Debug.Log("next scene");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }
    }
}

