using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Il2Cpp;
using UnityEngine.UI;

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


 
   
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
      

    }

    public void Scoreing()
    {   
        Score++;
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

}
