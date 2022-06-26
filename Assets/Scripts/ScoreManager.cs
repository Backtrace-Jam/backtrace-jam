using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    private int score;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    public void ChangeScore(int scoreValue)
    {
        score += scoreValue;
        text.text = "X" + score.ToString();

    }

    void Update()
    {
        if (score >= 1000)
        {
            YouWin();
        }
    }
    void YouWin()
    {
        text.text = "You Win !";
        SceneManager.LoadScene("Game Win"); 

    }


}
