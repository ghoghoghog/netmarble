using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareight : MonoBehaviour
{

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   private void Update()
    {
        
        rb.AddForce(new Vector2(2f, 0));
    }
        // Update is called once per frame
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Destroy(gameObject);
        }


    }
}
