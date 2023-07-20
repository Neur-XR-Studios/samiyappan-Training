using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform follow;
    public float lookatSpeed;
    public float followSpeed;
    public Vector3 offset;




    public void FixedUpdate()
    {
        Lookat();
        Follow();
    }
     public void Lookat()
     {
         Vector3 _lookDir = follow.position - transform.position;
         Quaternion rotation = Quaternion.LookRotation(_lookDir);
         transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookatSpeed * Time.deltaTime);
    }

    public void Follow()
    {
        Vector3 _tragetpos = follow.position + (follow.forward * offset.z + follow.right * offset.x + follow.up * offset.y);
        transform.position = Vector3.Lerp(transform.position, _tragetpos, lookatSpeed * Time.deltaTime);
    }


}