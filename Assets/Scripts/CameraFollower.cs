using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform Playerone;
    private Vector3 Tempos;
    [SerializeField]
    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        Playerone = GameObject.FindWithTag("Player").transform;
    }

     void LateUpdate()
    {

        if (!Playerone)
            return;
        Tempos = transform.position;
        Tempos.x = Playerone.position.x;

       /* if(Tempos.x < minX )
            Tempos.x = minX;
        if(Tempos.x > maxX )
            Tempos.x = maxX;   */     
        transform.position = Tempos;
        
    }

}
