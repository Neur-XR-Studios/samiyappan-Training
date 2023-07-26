using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawning : MonoBehaviour
{

    public GameObject spawning;
    public bool isplayer = false;
    public DirectionalArrow directionalArrowl;
    public GameObject[] Point1;
    public float[] distanceObject;
    int i;
    private void Update()
    {

    }


    void Start()
    {
        //Spawn();
        RandomObjects();
       
    }   
    public void Spawn()
    {
        isplayer = true;

        GameObject CustomerSpawn = Instantiate(spawning, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
        CustomerSpawn.transform.parent = transform;
        directionalArrowl.DetectArrow();

    }
   
  


    public void RandomObjects()
    {
        
        foreach (GameObject obj in Point1)
        {
            float distance = Vector3.Distance(Point1[0].transform.position, obj.transform.position);
            distanceObject[i] = distance;
            i++;    
            
           

            
        }


    }
}




































/*
        float Spawndistance = 10f;
        float Angle_x = Random.Range(-30, 30);
        float Angle_z = Random.Range(-40, 40);

        float spawnx = gameObject.transform.position.x + Spawndistance + Angle_x;
        float Spawny = gameObject.transform.position.z + Spawndistance + Angle_z ;
        GameObject CustomerSpawn = Instantiate(spawning, new Vector3(spawnx, gameObject.transform.position.y, Spawny), Quaternion.identity);*/
