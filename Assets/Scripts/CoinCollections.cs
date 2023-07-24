using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Il2Cpp;

public class CoinCollections : MonoBehaviour
{

    public TMP_Text Scorename;
    public int Score = 0;      
 
    public static CoinCollections instance;
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


}
