using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text ScoreText;
    public GameObject   PlayerOBJ;
    private int score = 0;
    //private int previousScore;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

       
       // previousScore = PlayerPrefs.GetInt("PreviousScore", 0);
       // ScoreManager.instance.SetScore(previousScore);
    }
    public void ObjectOne()
    {
        PlayerOBJ = GameObject.FindGameObjectWithTag("Player");
    }
    public int GetScore()
    {
        return score;
    }
  

    public void SetScore(int newScore)
    {
        score = newScore;
        UpdateScoreUI();
        // ScoreText.text = score_P.ToString();

        switch (PlayerOBJ.name)
        {
            case "Car(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);

                Debug.Log("ScoreManager");
                break;

            case "CarTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            case "CarPlayerOne(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);
                break;

            case "CarPlayerTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarPlayerThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            default:
                ///
                break;


        }

    }

    public void AddScore(int amount )
    {
        score += amount;
        UpdateScoreUI();
        // ScoreText.text = score_P.ToString();
        switch (PlayerOBJ.name)
        {
            case "Car(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);

                Debug.Log("ScoreManager");
                break;

            case "CarTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            case "CarPlayerOne(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);
                break;

            case "CarPlayerTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarPlayerThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            default:
                ///
                break;


        }
        //PlayerPrefs.SetInt("PreviousScore", score_P);
    }

    public void SubtractScore(int amount )
    {
        score -= amount;
        UpdateScoreUI();
        switch (PlayerOBJ.name)
        {
            case "Car(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);

                Debug.Log("ScoreManager");
                break;

            case "CarTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            case "CarPlayerOne(Clone)":
                PlayerPrefs.SetInt("Car_HighScore", score);
                break;

            case "CarPlayerTwo(Clone)":
                PlayerPrefs.SetInt("CarTwo_HighScore", score);
                break;

            case "CarPlayerThree(Clone)":
                PlayerPrefs.SetInt("CarThree_HighScore", score);
                break;

            default:
                ///
                break;


        }
        // ScoreText.text = score_P.ToString();
        //PlayerPrefs.SetInt("PreviousScore", score_P);
    }
    private void UpdateScoreUI()
    {
        if (ScoreText != null)
        {
            ScoreText.text = score.ToString();
        }
    }
}
