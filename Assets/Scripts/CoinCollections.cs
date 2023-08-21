using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Il2Cpp;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Tilemaps;

public class CoinCollections : MonoBehaviour
{
    public static CoinCollections instance;
    public TMP_Text Scorename;   
    public int Score = 0;  
    public Slider FuelSlider;
    public float CurrentFuel = 10f;
    public float maxFuel = 10f;
    public float UseFuel = 1f;
    public float MinValue = 1f;
    public string Names;


    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Scoreing()
    {
        Score = Score + 1;
        Scorename.text = Score.ToString();
    }

    public void PickupMoney()
    {
        Score = Score + 10;
        Scorename.text = Score.ToString();
    }
    public void DropMoney() 
    {
        Score = Score + 20;
        Scorename.text = Score.ToString();
    }
    public void IngnoreMoney()
    {
        Score = Score -10;
        Scorename.text = Score.ToString();
    }
    public void Fuel()
    {
      CurrentFuel -= UseFuel * Time.deltaTime;

        FuelSlider.value = CurrentFuel;
      if (CurrentFuel<MinValue)
      {
            CurrentFuel = 0;
      }
    }

    public void Refill()
    {
        CurrentFuel = maxFuel;
    }
    public void SaveScoreToCSV()
    {
        string filePath = Application.dataPath + "/scores.csv";        
        using (StreamWriter writer = File.AppendText(filePath))
        {
           
            writer.WriteLine(Score);
        }
       
      
        Debug.Log("Score saved to CSV: " + Score);
    }






}
