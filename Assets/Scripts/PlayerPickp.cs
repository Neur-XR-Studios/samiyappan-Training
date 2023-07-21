using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickp : MonoBehaviour
{
    public Spawning spawn;
    public GameObject SpawnObj;
   
    public GameObject PointDisable;
    public GameObject PlayerOne;
    public void Start()
    {
        SpawnObj = GameObject.Find("SpawningObjects");
        spawn = SpawnObj.GetComponent<Spawning>();

    }
 
    public void Droping()
    {

        PointDisable = GameObject.Find("A1 1");
        PlayerOne = GameObject.Find("People(Clone)");
    }


   /* public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Customer")
        {

            //
        }
        else if (other.gameObject.name == "Customer")
        {
            //
        }


    }*/
    public void Ignore()
    {
        Droping();
        Destroy(PlayerOne,5);
        spawn.Spawn();
      
        this.PointDisable.gameObject.SetActive(false);
     
    }
    public void Drop()
    {
        Droping();
        Destroy (PlayerOne);  
        spawn.Spawn();
    }
    public void Pickup()
    {
        Droping();
        spawn.Spawn();
        Destroy(PlayerOne);
        
    }



}
