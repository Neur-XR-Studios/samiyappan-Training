using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;


public class Spawning : MonoBehaviour
{

    public GameObject spawning;
    public bool isplayer = false;
    public DirectionalArrow directionalArrowl;
    public GameObject[] Point1;
    public float[] distanceObject;
    public float[] distance2;
    public List<float> distanceList;


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
        distanceObject = new float[Point1.Length];
        distance2 = new float[Point1.Length];

        foreach (GameObject obj in Point1)
        {
            float distance = Vector3.Distance(Point1[0].transform.position, obj.transform.position);
            distanceObject[i] = distance;

            if (distanceObject[i] > 150f)
            {
                distance2[j] = distanceObject[i];
                distanceList.Add(distance2[j]);                
                j++;


                // Debug.Log(obj);


            }

            if (distanceObject[i] > 150f)
               // if (distanceList.Count > 0)
            {

                int randomindex = Random.Range(0, distanceList.Count);
                GameObject randomObject = Point1[randomindex];
                Vector3 randomposition = randomObject.transform.position;

                Debug.Log("Distance " + obj.name + " random" + randomposition);
                GameObject spawnedObject = Instantiate(spawning, randomObject.transform.position, Quaternion.identity);
                spawnedObject.transform.parent = transform;
                directionalArrowl.DetectArrow();
                //break;
            }



            //if not take zero , put a if condition eg: distance2 > zero then  distanceWithNozero
            // print random number using distanceWithNozero array
            // then print random number 


            i++;
           
        }
    }
}