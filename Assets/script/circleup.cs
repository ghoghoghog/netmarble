using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleup: MonoBehaviour { 
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
     rb.AddForce(new Vector2(0, 5f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy( gameObject);
        }
        if (collision.gameObject.CompareTag("box"))
        {
            Destroy(gameObject);
        }

    }



}

