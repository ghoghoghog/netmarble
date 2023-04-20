using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletright : MonoBehaviour
{
    float currtime;
    public GameObject bulletobj;
    void Update()
    {
        currtime += Time.deltaTime;
        if (currtime > 7)
        {
            // x,y,z 좌표값을 각각 다른 범위에서 랜덤하게 정해지도록 만들었다.
            float newY = Random.Range(-11f, 11f);
            GameObject bullet = Instantiate(bulletobj);
            bullet.transform.position = new Vector3(-17, newY , 0);
            currtime = 0;
        }
        bulletobj.transform.Translate(Vector3.right * 300f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(obj: gameObject);
    }
}
