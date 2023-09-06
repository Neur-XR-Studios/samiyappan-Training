using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlayerSelection : MonoBehaviour
{


    private List<Action> functions = new List<Action>();


    private void Start()
    {
        functions.Add(Player1);
        functions.Add(Player2);
    }
    public void Player1()
    {
        Debug.Log(" player");
        Spawning.instance.ChangePlayer();
        SpawningObj.instance.CarsChange();
        
    }
    public void Player2()
    {
        Debug.Log("NoFunctions");
    }
     public void RandomCasllFunctions()
    {
        int randomoindex = UnityEngine.Random.Range(0,functions.Count);
        functions[randomoindex].Invoke();
    }
}
