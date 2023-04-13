using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletup : MonoBehaviour
{
    private Rigidbody2D rb;
    float currtime;
    public GameObject bulletobj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currtime += Time.deltaTime;
        if (currtime > 1)
        {
            
            float newX = Random.Range(-11f, 11f);
            GameObject bullet = Instantiate(bulletobj);
            bullet.transform.position = new Vector3(newX, -11, 0);
            currtime = 0;
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(obj: gameObject);
    }


}

