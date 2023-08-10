using System;
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
    public GameObject PlayerTwo;
   // public GameObject PlayerThree;
    public GameObject PlayerFour;
    public GameObject PlayerFive;
    //public PlayerWalk walking;
    
   
    public void Start()
    {
        SpawnObj = GameObject.Find("SpawningObjects");
        spawn = SpawnObj.GetComponent<Spawning>();


    }
    private void Update()
    {
        
    }
    public void Droping()
    {
        PlayerFour = GameObject.Find("WomenCustomerFollow");       
        PointDisable = GameObject.Find("A1 1");
        PlayerOne = GameObject.Find("People(Clone)");

    }
    public void Circle()
    {
        PlayerTwo = GameObject.Find("Magic circle 2");
    }
    public void Ignore()
    {
        Circle();
        PlayerFive.GetComponent<SkinnedMeshRenderer>().enabled = true;       
        GetSpawnObj2();
        Droping();
        DestroyingObj();
        Destroy(PointDisable);
        spawn.RandomObjects();       
        PlayerTwo.gameObject.SetActive(false);
      //  PlayerThree.GetComponent<SkinnedMeshRenderer>().enabled = true;
        this.PointDisable.gameObject.SetActive(false);
    }
    public void Drop()
    {
        Circle();

        Droping();
        spawn.RandomObjects();
        Destroy(PlayerOne);
        Destroy(PointDisable);
        Destroy(PlayerTwo);
        CoinCollections.instance.DropMoney();
      //  PlayerThree.GetComponent<SkinnedMeshRenderer>().enabled = false;



    }
    public void Pickup()
    {
        Circle();
        GetSpawnObj();
        CoinCollections.instance.PickupMoney();
        Destroy(PointDisable);
        Destroy(PlayerOne);
        Destroy(PlayerTwo);
        spawn.RandomObjects();
        spawn.DisableMesh();
       // PlayerThree.GetComponent<SkinnedMeshRenderer>().enabled = false;
        Droping();
    }
    public void GetSpawnObj()
    {

        for (int i = 0; i < SpawnObj.transform.childCount - 1; i++)
        {
            GameObject child = SpawnObj.transform.GetChild(i).gameObject;
            Destroy(child);
            // Debug.Log(i);
        }
    }
    public void GetSpawnObj2()
    {
        if ((SpawnObj.transform.childCount >= 1))
        {
            for (int i = 0; i < SpawnObj.transform.childCount - 1; i++)
            {
                GameObject child = SpawnObj.transform.GetChild(i).gameObject;
                Destroy(child);
                //Debug.Log(i);
            }
        }
    }
    public void DestroyingObj()

    {
        Droping();
        PlayerFive.GetComponent<SkinnedMeshRenderer>().enabled = true;
        Destroy(PlayerFour);
        

    }






}
