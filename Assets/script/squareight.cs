using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareight : MonoBehaviour
{

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   private void Update()
    {
        
        rb.AddForce(new Vector2(2f, 0));
    }
        
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("box"))
        {
            Destroy(gameObject);
        }

    }
}
