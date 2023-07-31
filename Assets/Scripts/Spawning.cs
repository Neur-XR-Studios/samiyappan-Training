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

    public GameObject spawning;
    public bool isplayer = false;
    public DirectionalArrow directionalArrowl;
    public GameObject[] Point1;
    public float[] distanceObject;
    public float[] distance2;   
    public List<float> distanceList;
    public List<float> RandoRangePeople;


    int i = 0;
    int j = 0;

    void Start()
    {
        //Spawn();
        RandomObjects();
    }


    public void Spawn()
    {
        isplayer = true;
/*
        GameObject CustomerSpawn = Instantiate(spawning, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
        CustomerSpawn.transform.parent = transform;
        directionalArrowl.DetectArrow();*/
    }



    public void RandomObjects()
    {


        //distanceObject = new float[Point1.Length];
        //distance2 = new float[Point1.Length];
     
       
       // distanceObject.AddRange(new List<float>());
      //  distance2 .AddRange(new List<float>());

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
                // Debug.Log(obj);
            }
            //if not take zero , put a if condition eg: distance2 > zero then  distanceWithNozero// print random number using distanceWithNozero array // then print random number 


            i++;
            
        }

        int traveller = Random.Range(0, 50);
        GameObject randomPerson = Point1[traveller];
        Vector3 randompositionofAPerson = randomPerson.transform.position;
        GameObject spawnedperson = Instantiate(spawning, randomPerson.transform.position, Quaternion.identity);
        spawnedperson.transform.parent = transform;
        directionalArrowl.DetectArrow();
        Debug.Log("Distance " + " random" + randompositionofAPerson);

    }
     public  void ClearArray()
    {
      
        Array.Clear(distanceObject, 0, distanceObject.Length);
    }


}