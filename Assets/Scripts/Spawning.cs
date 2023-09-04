using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using System;
using Random = UnityEngine.Random;


public class Spawning : MonoBehaviour
{
    public static Spawning instance;

    public GameObject spawning;
    public GameObject spawningtwo;
    public bool isplayer = false;
    public DirectionalArrow directionalArrowl;
    public GameObject[] Point1;
    public float[] distanceObject;
    public float[] distance2;
    public List<float> distanceList;//= new List<float>();  
    public List<float> RandoRangePeople;
    public SkinnedMeshRenderer skinnedMeshRenderer;

    int i = 0;
    int j = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
     
        //Spawn();
       // RandomObjects();
    }
    private void Update()
    {
       
    }


    public void Spawn()
    {
       
/*
        GameObject CustomerSpawn = Instantiate(spawning, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
        CustomerSpawn.transform.parent = transform;
        directionalArrowl.DetectArrow();*/
    }



    public void RandomObjects()
    {
        i = 0;
        j = 0;

        distanceList.Clear();

        Array.Clear(distanceObject,0, distanceObject.Length);
        Array.Clear(distance2,0, distance2.Length);

      
        foreach (GameObject obj in Point1)
        {
            
            float distance = Vector3.Distance(Point1[0].transform.position, obj.transform.position);            
            distanceObject[i] = distance;

          //  Debug.Log(distanceObject[i]);

            if (distanceObject[i] > 150f)
            {
                distance2[j] = distanceObject[i]; 
                distanceList.Add(distance2[j]);                
                j++;
                // Debug.Log(SpawnCar);
            }
            //if not take zero , put a if condition eg: distance2 > zero then  distanceWithNozero// print random number using distanceWithNozero array // then print random number 
            i++;
        }

        int traveller = Random.Range(0, Point1.Length);
        GameObject randomPerson = Point1[traveller];
        Vector3 randompositionofAPerson = randomPerson.transform.position;
        isplayer = true;
        GameObject spawnedperson = Instantiate(spawning, randomPerson.transform.position, Quaternion.identity);      
        skinnedMeshRenderer = spawnedperson.GetComponentInChildren<SkinnedMeshRenderer>();
        spawnedperson.transform.parent = transform;
        directionalArrowl.DetectArrow();
        Debug.Log("Distance " + " random" + randompositionofAPerson);
        
    }
    public void DisableMesh()
    {
        skinnedMeshRenderer.enabled = false;
    }
    public void ChangePlayer()
    {
     //   RandomObjects();
        spawning = spawningtwo;
        Debug.Log("ChangePlayer");
    }
}