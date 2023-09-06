using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeRotate : MonoBehaviour
{
    public enum Axis
    {
        x,
        y,
        z

    }

    public Axis rotationaxis;
    private float bladespeed = 3000;
    public bool  inversrotation = false;
    private Vector3 rotation_blade;
    private float rotationdegree;




    public void Start()
    {
        rotation_blade = transform.localEulerAngles;

    }
    public void Update()
    {
        if (inversrotation) 
        {
           rotationdegree -= bladespeed*Time.deltaTime;
        }
        else
        {
            rotationdegree += bladespeed*Time.deltaTime;
            rotationdegree = rotationdegree%360;
            switch (rotationaxis) 
            {
                case Axis.y:
                    transform.localRotation = Quaternion.Euler(rotation_blade.x, rotationdegree, rotation_blade.z);
                    break;
                case Axis.z:
                    transform.localRotation = Quaternion.Euler(rotation_blade.x,  rotation_blade.y, rotationdegree);
                    break;
                default:
                    transform.localRotation = Quaternion.Euler(rotationdegree, rotation_blade.y, rotation_blade.z);
                    break;

            }
        }

    }

}
