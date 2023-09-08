using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform[] Enemy_H;
    public float speed;
    private int currentTargetIndex = 0;
    public int IndexVlaue;
    public string Pointone;
    public string PointTwo;
    private Transform player;



    public void Start() 
    {
        Enemy_H[0] = GameObject.Find(Pointone).transform;
        Enemy_H[1] = GameObject.Find(PointTwo).transform;


        player = GameObject.FindGameObjectWithTag("Player").transform; 
    }
    void Update()
    {
        if (Enemy_H != null)
        {
            Vector3 targetPosition = Enemy_H[IndexVlaue].position;
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            transform.position = newPosition;
            transform.LookAt(player);
            if(Vector3.Distance(transform.position,targetPosition)< 2f )
            {



                if (currentTargetIndex >= Enemy_H.Length)
                {
                    
                }
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Shoot"))

        {

            ScoreValues.Instance.RemoveScore(1);
            Destroy(gameObject);
        }
       else if(other.gameObject.CompareTag("Shoot1"))

        {
            ScoreValues.Instance.RemoveScore(1);
            Destroy(gameObject);
        }
    }

}
