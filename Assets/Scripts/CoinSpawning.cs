using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawning : MonoBehaviour
{

    public GameObject CoinSpawn;

    // Start is called before the first frame update
    void Awake()
    {
       StartCoroutine(Coins());      
       
    }

    // Update is called once per frame
    void Update()
    {      
       
    }
    IEnumerator Coins()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            GameObject SpawnCoin = Instantiate(CoinSpawn, new Vector3(Random.Range(-30, 30), gameObject.transform.position.y, Random.Range(-40, 40)), Quaternion.identity);
            SpawnCoin .transform.parent = transform;
        }

    }

}


