using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptIgnore : MonoBehaviour
{
    public PlayerPickp playerPickp;
    public GameObject Arrow;

    public static bool Accept= false;
    public void Update()
    {
      U1();
    }
    public void  IGN()
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
}
