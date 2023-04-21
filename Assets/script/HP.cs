using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class HP : MonoBehaviour
{
    public string sceneName;
    [SerializeField]
    private TextMeshProUGUI hp;
    private float currenthp = 3;

    public TextMeshProUGUI score;
    
    private float currentValue = 0f;
    public float increaseAmountPerSecond = 10f;

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
        currentValue += increaseAmountPerSecond * Time.deltaTime;
        score.text = currentValue.ToString("F0");

        hp.text = "HP: " + currenthp.ToString();
        if (currenthp == 0)
        {
            //Time.timeScale = 0f;
            SceneManager.LoadScene((sceneName));
        }





    }





}
