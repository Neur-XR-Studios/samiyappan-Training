using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform Enemy_H;
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Enemy_H != null)
        {
            Vector3 targetPosition = Enemy_H.position;
            Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
            transform.position = newPosition;
        }
    }
}
