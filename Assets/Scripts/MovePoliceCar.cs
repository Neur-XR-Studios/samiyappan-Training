using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoliceCar : MonoBehaviour
{
    public static MovePoliceCar instance;
  
   // public Transform toobject;
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
            CarControll.Currentbreakforce = 0f;
           
            //gameObject.GetComponent<MovePoliceCar>().enabled = false;
            CarControll.instance.StopWheel();

            Application.Quit();
            

        }
    }

 
}
