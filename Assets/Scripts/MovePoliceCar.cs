using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoliceCar : MonoBehaviour
{
    public static MovePoliceCar instance;
  
  
    public float speed;
    public PlayerWalk walk;
    public GameObject carfind;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
         carfind = GameObject.Find("PolicePoint");
         transform.position = Vector3.MoveTowards(transform.position,carfind.transform.position, speed* Time.deltaTime);
         transform.LookAt(carfind.transform.position);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("police"))
        {
            SpawnPolice.instance.ButtonDisable();
            CarControll.Currentbreakforce = 0f; 
           // CarControll.instance.StopWheel();
            CarControll.instance.enabled = false;
            CoinCollections.instance.SaveScoreToCSV();
        }
    }

 
}
