using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HP : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI hp;
    private float currenthp = 3;
    [SerializeField]
    private TextMeshProUGUI score;
    
    private float currentValue = 0f;
    public float increaseAmountPerSecond = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            currenthp -= 1;
        }


    }
  
    
    
    private void Update()
    {
        currentValue += increaseAmountPerSecond * Time.deltaTime;
        score.text = currentValue.ToString("F0");

        hp.text = "HP: " + currenthp.ToString();
        if (currenthp == 0)
        {
            Time.timeScale = 0f;
        }





    }





}