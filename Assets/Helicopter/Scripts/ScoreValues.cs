using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValues : MonoBehaviour
{

    public static ScoreValues Instance;
    public int score_P = 10;
    public TMP_Text ScoreCount;
    public Slider SliderValue = null;
  

  
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void Update()
    {
        ScoreCount.text = score_P.ToString();
        SliderValue.value = score_P;
    }
    
    public void AddScore(int amount)
    {
        score_P += amount;
    }
    public void RemoveScore(int amount)
    {
        if (score_P < 1)
        {
            score_P = 1;
        }
        score_P -= amount;
    }
}
