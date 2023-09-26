using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject end;
    public GameObject transition;
    private float heightvalue = 7;
    private float widthvalue = 8;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spwancoin", 1, 1);
        InvokeRepeating("spwancoin", 3, 4);
        InvokeRepeating("spwanend", 4, 2);
        InvokeRepeating("spwantransition", 6, 5);
    }

    public void spwanend()
    {
        Vector3 pos = new Vector3(Random.Range(-widthvalue, widthvalue), heightvalue, 0);
        GameObject endclone = Instantiate(end, pos, Quaternion.identity);
    }

    public void spwancoin()
    {
        Vector3 pos = new Vector3(Random.Range(-widthvalue, widthvalue), heightvalue, 0);
        GameObject coinclone = Instantiate(coin, pos, Quaternion.identity);
    }

    public void spwantransition()
    {
        Vector3 pos = new Vector3(Random.Range(-widthvalue, widthvalue), heightvalue, 0);
        GameObject transitionclone = Instantiate(transition, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
