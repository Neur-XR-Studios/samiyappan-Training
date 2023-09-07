using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHelicopter : MonoBehaviour
{
public GameObject helicopter;



    public void SpawningHelicopter()
    {
        GameObject SpawnHelicopter = Instantiate(helicopter, transform.position,Quaternion.identity);
    }

}
