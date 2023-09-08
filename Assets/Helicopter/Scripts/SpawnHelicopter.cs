using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHelicopter : MonoBehaviour
{
public GameObject helicopter;

    public void SpawningHelicopter()
    {
        GameObject SpawnHelicopter = Instantiate(helicopter, transform.position,Quaternion.identity);
        SpawnHelicopter.transform.parent = transform;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Shoot"))
        {
            Destroy(this.gameObject);

        }
    }

}
