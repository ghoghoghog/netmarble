using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet: MonoBehaviour
{
    float currtime;
    public GameObject bulletobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currtime += Time.deltaTime;
        if (currtime > 1)
        {
            // x,y,z ��ǥ���� ���� �ٸ� �������� �����ϰ� ���������� �������.
            float newX = Random.Range(-11f, 11f);
            GameObject bullet = Instantiate(bulletobj);
            bullet.transform.position = new Vector3(newX, 11, 0);
            currtime = 0;
        }
        bulletobj.transform.Translate(Vector3.down * 300f);
    }
}
