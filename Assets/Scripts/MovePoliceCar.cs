using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePoliceCar : MonoBehaviour
{

    public static MovePoliceCar instance;
    public GameObject police;

    public float speed;
    public GameObject carfind;
    public GameObject explosionPrefab; 

    private bool exploded = false; 

    
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

   
    void Update()
    {
        carfind = GameObject.Find("PolicePoint");
        transform.position = Vector3.MoveTowards(transform.position, carfind.transform.position, speed * Time.deltaTime);
        transform.LookAt(carfind.transform.position);

        if (!exploded && Vector3.Distance(transform.position, carfind.transform.position) < 0.1f)
        {
           
             ExplodeAndLoadScene();
        }
        else
        {
            //
        }
    }

    private void ExplodeAndLoadScene()
    {
        police.SetActive(true);
        gameObject.GetComponent<PoliceArrest>().enabled = true;
        // exploded = true;
        //Instantiate(explosionPrefab, transform.position, Quaternion.identity);    
    }
}
