using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float Speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        Destroy(gameObject, 20);
    }


    // Update is called once per frame
    void  FixedUpdate() 
    {
        transform.Rotate(0, Speed * Time.deltaTime, 0 );
    }
}
