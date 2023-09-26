using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movement : MonoBehaviour
{
    public float speed = 300;
    Rigidbody2D rb;
    float xMove;
    public TextMeshPro playerscoretext;
    int playerscore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    }
}
