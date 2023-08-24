using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceArrest : MonoBehaviour
{
    public static PoliceArrest Instance;
    public Transform[] targetWords; 
    public float speed;
    private int currentTargetIndex = 0;
    public Animator animator;
  
 

    public void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        targetWords = new Transform[5];
        targetWords[0] = GameObject.Find("Police1").transform;
        targetWords[1] = GameObject.Find("Police2").transform;
        targetWords[2] = GameObject.Find("Police3").transform;
        targetWords[3] = GameObject.Find("Police4").transform;
        targetWords[4] = GameObject.Find("Police5").transform;
        animator = GetComponent<Animator>();
    }


    void Update()
    {
     
        DropCustomer();
    }
   
    public void DropCustomer()
    {
        if (targetWords.Length == 0) return;

        Vector3 targetPosition = targetWords[currentTargetIndex].position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        transform.LookAt(targetPosition);

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            currentTargetIndex++;

            if (currentTargetIndex >= targetWords.Length)
            {
                enabled = false;
                SpawnPolice.instance.ButtonDisable();
            }
        }
    }

}
