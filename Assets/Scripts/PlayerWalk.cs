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
    
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        targetWords = new Transform[3];
        targetWords[0] = GameObject.Find("point1").transform; 
        targetWords[1] = GameObject.Find("point2").transform;
        targetWords[2] = GameObject.Find("point3").transform;


        animator = GetComponent<Animator>();
    }

    void Update()
    {

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
            // If the object is very close to the current target, move to the next one
            currentTargetIndex++;

            // Check if we have reached the last target
            if (currentTargetIndex >= targetWords.Length)
            {
                // Stop moving the GameObject
                animator.enabled = false;
                enabled = false;
                

               // Debug.Log("Reached the last element. Movement stopped.");
            }
        }
    }
   
}
