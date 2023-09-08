using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValues : MonoBehaviour
{

    public static ScoreValues Instance;
    public int score = 10;
    public Slider SliderValue = null;


    // Start is called before the first frame update
    void Start()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        SliderValue.value = score;
    }
    public void Update()
    {
        SliderValue.value = score;
    }
    // Update is called once per frame
    public void AddScore(int amount)
    {
        score += amount;

    }
    public void RemoveScore(int amount)
    {
        if (score < 1)
        {
            score = 1;
        }

        score -= amount;

    }
}
