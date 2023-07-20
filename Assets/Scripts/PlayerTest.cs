using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest 
{
    public int Score;
    public string name;
    public float health;


    public PlayerTest(int Score,string name, float health)
    {

        this .Score = Score;   
        this.name = name;
        this.health = health;       


    }
    public void Attack()
    {
        Debug.Log(name + " Do you ussualy like Drinking");
    }
     public void Info()
    {
        Debug.Log(" score " + Score);
        Debug.Log("name" + name);
        Debug.Log("health" + health);
    }

}
