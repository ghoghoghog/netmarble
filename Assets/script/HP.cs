using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI hp;
    private float currenthp = 3;
    [SerializeField]
    private TextMeshProUGUI text;





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            currenthp -= 1;
        }
        if (collision.gameObject.CompareTag("heart"))
        {
            currenthp += 1;
        }
        if(currenthp > 3)
        {
            currenthp = 3;
        }
    }
  
    
    
    private void Update()
    {
        

        hp.text = "HP: " + currenthp.ToString();
        if (currenthp == 0)
        {
            Time.timeScale = 0f;
            
        }





    }
    



}
