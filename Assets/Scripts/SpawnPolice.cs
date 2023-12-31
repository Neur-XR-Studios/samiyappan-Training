using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPolice : MonoBehaviour
{
   
    public static SpawnPolice instance;
    public GameObject PoliceSpawn;
 
    void Start()
    {
      
        if(instance == null)
        {
            instance = this;
        }
    }
   public void PoliceSpawning()
    {
        GameObject PoliceSpawnOn = Instantiate(PoliceSpawn, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
        PoliceSpawnOn.transform.parent = transform;
    }
}
