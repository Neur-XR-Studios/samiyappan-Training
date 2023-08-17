using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPlayer : MonoBehaviour
{

    public static DropPlayer Instance;
    public Transform[] targetWords; // An array of target positions
    public float speed;
    private int currentTargetIndex = 0;
    public Animator animator;
    public Animator Dopen;
    public GameObject Door;
    public GameObject Objone;
    
   
    public void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Door = GameObject.Find("door_front_L");
        Dopen = GameObject.Find("door_front_L").GetComponent<Animator>();
      
        targetWords = new Transform[5];
        targetWords[0] = GameObject.Find("Dpoint5").transform;
        targetWords[1] = GameObject.Find("Dpoint4").transform;
        targetWords[2] = GameObject.Find("Dpoint3").transform;
        targetWords[3] = GameObject.Find("Dpoint2").transform;
        targetWords[4] = GameObject.Find("Dpoint1").transform;
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        // Objone = GameObject.Find("People(Clone)");
        // DropCustomer();
        DropCustomer();
    }
    public void OpenDoor()
    {
        animator.enabled = true;
        Dopen.enabled = true;
        Dopen.Play("Open_door");

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
              // animator.enabled = true;
                enabled = false;
               // Dopen.enabled = true;
               //open.Play("Open_door");
                Destroy(gameObject, 1f);
                Destroy(Objone, 1.3f);
                AcceptIgnore.instance.Drop1();





                PlayerPickp.instance.Ignore();


            }
        }
    }


}
