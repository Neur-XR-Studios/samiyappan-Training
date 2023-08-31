using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform follow;
    public float lookatSpeed;
    public float followSpeed;
    public Vector3 offset;
    public Transform cameraHolder;

    private void Start()
    {
       
        GameObject objectToFind = GameObject.Find("MainCamera");
        if (objectToFind != null)
        {
            Transform objectTransform = objectToFind.transform;
            
        }
    }

    private void FixedUpdate()
    {
        Lookat();
        Follow();
    }

    private void Lookat()
    {
        Vector3 lookDir = follow.position - cameraHolder.position;
        Quaternion rotation = Quaternion.LookRotation(lookDir);
        cameraHolder.rotation = Quaternion.Lerp(cameraHolder.rotation, rotation, lookatSpeed * Time.deltaTime);
    }

    private void Follow()
    {
        Vector3 targetPos = follow.position + (follow.forward * offset.z + follow.right * offset.x + follow.up * offset.y);
        cameraHolder.position = Vector3.Lerp(cameraHolder.position, targetPos, followSpeed * Time.deltaTime);
    }
}