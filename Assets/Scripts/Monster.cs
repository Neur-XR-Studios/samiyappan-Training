using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float Speed;
    private Rigidbody2D myrigidbody;
    // Start is called before the first frame update
    void Awake()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        Speed = 5;
    }

    // Update is called once per frame
    void LateUpdate()
    { 
    
     myrigidbody.velocity = new Vector2(Speed, myrigidbody.velocity.y)  ;
    
    
    }    
}
