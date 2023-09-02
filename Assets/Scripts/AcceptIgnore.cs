using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptIgnore : MonoBehaviour
{
    public static AcceptIgnore instance;
    public PlayerPickp playerPickp;
    public GameObject Arrow;
    public PlayerWalk walk;
    public Animator walkWalk;
    public GameObject DropingPoints;
    public DropPlayer DroppedPlayer;
    
   
   
    public static bool Accept = false;


    public void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        Accept = false;
    }
    public void Update()
    {
        DropingPoints = GameObject.Find("Droping");
    }
    public void IGN()
    {
        U1();
        playerPickp.Ignore();
    }
    public void Drop1()
    {
        U1();
        Accept = false;      
        playerPickp.Drop();
    }
    public void pickup()
    {
        U1();
        Accept = true;
        playerPickp.Pickup();
      
    }
    public void U1()
    {
        walk = GameObject.Find("WomenCustomerFollow").GetComponent<PlayerWalk>();
        
        walkWalk = GameObject.Find("WomenCustomerFollow").GetComponent<Animator>();

        Arrow = GameObject.Find("A1 1");
        playerPickp = Arrow.GetComponent<PlayerPickp>();

        
    }
    public void U2()
    {

        U1();
        walk.enabled = true;
        walk.MoveToNextWord();
        walkWalk.enabled = true;
        Debug.Log(" move");
        
      


    }

    public void DropDeActive()
    {
      //  DropingPoints = GameObject.Find("Droping");
        DropingPoints.SetActive(false);


    }
    public void DropActive()
    {
       // DropingPoints = GameObject.Find("Droping");
        DropingPoints.SetActive(true);
    }
    public void  DropAnimation()
    {
       
        DroppedPlayer = GameObject.Find("DropPlayer").GetComponent<DropPlayer>();
        walkWalk.enabled=true;
        





    }
}