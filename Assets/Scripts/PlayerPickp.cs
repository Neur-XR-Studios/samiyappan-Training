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

        spawn.Spawn();
        GetSpawnObj2();
        Droping();

        this.PointDisable.gameObject.SetActive(false);

    }
    public void Drop()
    {

        Droping();
        Destroy(PlayerOne);
        spawn.Spawn();

    }
    public void Pickup()
    {
        spawn.Spawn();
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
