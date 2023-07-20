using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector2 pos = transform.position;

        pos.x += h * Time.deltaTime;
        pos.y += V * Time.deltaTime;
        transform.position = pos;
    }
}
