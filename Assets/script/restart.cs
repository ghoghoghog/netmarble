using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class restart : MonoBehaviour
{
    public Button myButton;
    public string game;
    void Start()
    {
        myButton.onClick.AddListener(Restart);
    }

    void Restart()
    {
        SceneManager.LoadScene(game);
    }
}
