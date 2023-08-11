using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{

    public static PlayerWalk Instance;
    public Transform[] targetWords; // An array of target positions
    public float speed;
    private int currentTargetIndex = 0;
    public Animator animator;
    public Animator Dopen;
    public GameObject Door;
    public GameObject Objone;
  
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Door = GameObject.Find("door_front_L");
        Dopen = GameObject.Find("door_front_L").GetComponent<Animator>();
        targetWords = new Transform[3];
        targetWords[0] = GameObject.Find("point1").transform; 
        targetWords[1] = GameObject.Find("point2").transform;
        targetWords[2] = GameObject.Find("point3").transform;


        animator = GetComponent<Animator>();
       


        
    }


    void Update()
    {
        Objone = GameObject.Find("People(Clone)");
        MoveToNextWord();
    }

   public  void MoveToNextWord()
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
                animator.enabled = false;
                enabled = false;
                Dopen.enabled = true;
                Dopen.Play("Open_door");
                Destroy(gameObject,1f);
                Destroy(Objone,1.3f);
                AcceptIgnore.instance.DropDeActive();
            }
        }
    }
   
}
