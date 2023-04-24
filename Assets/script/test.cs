using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
   

public class test : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    private int _myScore = 0;
    private int _bestScore = 0;
    public float increaseAmountPerSecond = 10f;
    private float _timer = 0f;
    public static test Instance { get; private set; }

    public int myScore
    {
        get => _myScore;
        set
        {
            _myScore = value;
            if (_myScore > _bestScore)
            {
                _bestScore = _myScore;
                PlayerPrefs.SetInt("bestScore", _bestScore);
            }
            printScore();
        }
    }

    private void printScore()
    {
        text.text = $"My Score : {_myScore}\nBest Score : {_bestScore}";
    }

    public int bestScore
    {
        get => _bestScore;
    }

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("bestScore", 100);
        myScore = 0;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 1f)
        {
            _timer = 0f;
            myScore += (int)increaseAmountPerSecond;
        }
    }

}
