using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    float currtime;
    public GameObject heartobj;
    void Update()
    {
        currtime += Time.deltaTime;
        if (currtime > 10)
        {
            // x,y,z ��ǥ���� ���� �ٸ� �������� �����ϰ� ���������� �������.
            float newY = Random.Range(-10f, 10f);
            float newX = Random.Range(-10f, 10f);
            GameObject bullet = Instantiate(heartobj);
            bullet.transform.position = new Vector3(newX, newY, 0);
            currtime = 0;
        }
    }
}