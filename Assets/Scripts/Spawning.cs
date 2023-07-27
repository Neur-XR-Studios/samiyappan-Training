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
    int i;
    int j;

    private void Update()
    {

    }


    void Start()
    {
        Spawn();
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
            //distanceObject = new float[obj.Length];
          




            float distance = Vector3.Distance(Point1[0].transform.position, obj.transform.position);
            distanceObject[i] = distance;



            if (distanceObject[i] > 100)
            {

                distance2[i] = distanceObject[i];


            }
        


            i++;

        }
        if (distance2.Length > 0)
        {
            int indexArrayDistance2 = Random.Range(0, distance2.Length);
            float distanceArrayDistance2 = distance2[indexArrayDistance2];
            Debug.Log("take elemrnt distance" + distanceArrayDistance2);
            Debug.Log(" array Elemrnt " + indexArrayDistance2);


        }




    }
}


