using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text ScoreText;
    private int score = 0;
    private int previousScore;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        previousScore = PlayerPrefs.GetInt("PreviousScore", 0);
        ScoreManager.instance.SetScore(previousScore);
    }

    public int GetScore()
    {
        return score;
    }
  

    public void SetScore(int newScore)
    {
        score = newScore;
        ScoreText.text = score.ToString();
    }

    public void AddScore(int amount )
    {
        score += amount;
        ScoreText.text = score.ToString();
    }

    public void SubtractScore(int amount )
    {
        score -= amount;
        ScoreText.text = score.ToString();
    }
}
