using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptIgnore : MonoBehaviour
{
    public PlayerPickp playerPickp;
    public GameObject Arrow;
    public PlayerWalk walk;
    public Animator walkWalk;
   
   
    public static bool Accept = false;
    public void Update()
    {
        U1();

        walk = GameObject.Find("WomenCustomerFollow").GetComponent<PlayerWalk>();
        walkWalk = GameObject.Find("WomenCustomerFollow").GetComponent<Animator>();
       

        
       
        


    }
    public void IGN()
    {
        playerPickp.Ignore();
    }
    public void Drop1()
    {
        Accept = false;
        playerPickp.Drop();
    }
    public void pickup()
    {
        Accept = true;
        playerPickp.Pickup();
    }
    public void U1()
    {
        Arrow = GameObject.Find("A1 1");
        playerPickp = Arrow.GetComponent<PlayerPickp>();
    }
    public void U2()
    {
        
       
        walk.enabled = true;
        walk.MoveToNextWord();
        walkWalk.enabled = true;
        Debug.Log(" move");
        
      


    }
}