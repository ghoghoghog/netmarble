using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public float increaseAmountPerSecond = 10f;
    [SerializeField] private TextMeshProUGUI text;
    private int _myScore ;
    private int _bestScore = 100;
    public static Score Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int myScore
    {
        get => _myScore;
        set
        {
            _myScore = value;

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
        _bestScore = PlayerPrefs.GetInt("bestScore", 200);
        printScore();
    }

    private void Update()
    {
        _myScore += (int)(increaseAmountPerSecond );
        if (_myScore > _bestScore)
        {
            _bestScore = _myScore;
            PlayerPrefs.SetInt("bestScore", _bestScore);
        }
        printScore();
    }

}
