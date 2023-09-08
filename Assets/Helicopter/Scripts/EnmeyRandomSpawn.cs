using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmeyRandomSpawn : MonoBehaviour
{
    public GameObject helicopter;

    public void SpawningHelicopter()
    {


        GameObject SpawnEnemy = Instantiate(helicopter, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y + 0.5f, Random.Range(-40, 40)), Quaternion.identity);
        SpawnEnemy.transform.parent = transform;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shoot"))
        {
            Destroy(this.gameObject);

        }


    }
}
