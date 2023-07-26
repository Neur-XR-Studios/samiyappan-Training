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
    public GameObject PlayerThree;
    
    public void Start()
    {
        SpawnObj = GameObject.Find("SpawningObjects");
        spawn = SpawnObj.GetComponent<Spawning>();

    }
    private void Update()
    {
        PlayerTwo = GameObject.Find("Magic circle 2");
        PlayerThree = GameObject.Find("WomenCustomer");

    }

    public void Droping()
    {

        PointDisable = GameObject.Find("A1 1");
        PlayerOne = GameObject.Find("People(Clone)");
       
           
        
    }


    public void Ignore()
    {
        Droping();
        spawn.Spawn();
       // CoinCollections.instance.IngnoreMoney();
        PlayerTwo.gameObject.SetActive(false);
        PlayerThree.GetComponent<SkinnedMeshRenderer>().enabled = true;


        GetSpawnObj2();
       


        this.PointDisable.gameObject.SetActive(false);

    }
    public void Drop()
    {
        CoinCollections.instance.DropMoney();
       
        Droping();
        Destroy(PlayerOne);
        spawn.Spawn();

    }
    public void Pickup()
    {
        CoinCollections.instance.PickupMoney();
        spawn.Spawn();
        PlayerThree.GetComponent<SkinnedMeshRenderer>().enabled = false;
        GetSpawnObj();
        Droping();
        Destroy(PlayerOne);

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

        if ((SpawnObj.transform.childCount > 1))
        {

            for (int i = 0; i < SpawnObj.transform.childCount - 2; i++)
            {
                GameObject child = SpawnObj.transform.GetChild(i).gameObject;
                Destroy(child);
                //Debug.Log(i);
            }
        }
    }



}
