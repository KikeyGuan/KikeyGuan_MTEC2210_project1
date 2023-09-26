using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppedend : MonoBehaviour
{
    public float stopvalue = 0;
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            speed = 0;
            collision.gameObject.GetComponent<movement>().Stop(stopvalue);
            //end game
            Destroy(gameObject);
        }
    }

}
