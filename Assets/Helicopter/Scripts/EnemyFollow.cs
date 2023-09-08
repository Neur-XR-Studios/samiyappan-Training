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



    public void Start() 
    {
        Enemy_H[0] = GameObject.Find(Pointone).transform;
        Enemy_H[1] = GameObject.Find(PointTwo).transform;

    }
    void Update()
    {
        if (Enemy_H != null)
        {
            Vector3 targetPosition = Enemy_H[IndexVlaue].position;
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            transform.position = newPosition;

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
            Destroy(gameObject);
        }
    }

}
