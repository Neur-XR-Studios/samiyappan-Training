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

            GameObject CustomerSpawn = Instantiate(spawning, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
            CustomerSpawn.transform.parent = transform;
            directionalArrowl.DetectArrow();
        
    }



}
