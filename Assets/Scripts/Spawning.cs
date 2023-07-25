using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject spawning;
    public bool isplayer = false;
    public DirectionalArrow directionalArrowl;

    void Start()
    {
        Spawn();
    }   
    public void Spawn()
    {
        isplayer = true;


        float Spawndistance = 10f;
        float Angle_x = Random.Range(-30, 30);
        float Angle_z = Random.Range(-40, 40);

        float spawnx = gameObject.transform.position.x + Spawndistance + Angle_x;
        float Spawny = gameObject.transform.position.z + Spawndistance + Angle_z ;
        GameObject CustomerSpawn = Instantiate(spawning, new Vector3(spawnx, gameObject.transform.position.y, Spawny), Quaternion.identity);



        //GameObject CustomerSpawn = Instantiate(spawning, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
        CustomerSpawn.transform.parent = transform;
         directionalArrowl.DetectArrow();

    }
  


}
