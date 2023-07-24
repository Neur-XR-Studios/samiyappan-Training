using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float Speed = 100f;
    public GameObject CoinExplotion;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        Destroy(gameObject, 20);
    }


    // Update is called once per frame
    void  FixedUpdate() 
    {
        transform.Rotate(0, Speed * Time.deltaTime, 0 );
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coinexplosion"))
        {
         GameObject  CoinEX =  Instantiate (CoinExplotion,transform.position,Quaternion.identity);
         CoinCollections.instance.Scoreing();
         Destroy(gameObject); 
         Destroy(CoinEX ,1);
         

        }

    }
}
