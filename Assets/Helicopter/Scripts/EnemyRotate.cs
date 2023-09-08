using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyRotate : MonoBehaviour
{
    public enum Axis
    {
        x,
        y, 
        z
    }

    public Axis axis;
    private Vector3 enemy;
    public float Blade_value;
   

    
    
    void Start()
    {
       
    }


    void Update()
    {
        switch(axis)
        {
            case Axis.x:
                transform.Rotate(new Vector3(enemy.x, Blade_value, enemy.z));
                break;
            case Axis.y:
                transform.Rotate(new Vector3(enemy.x,enemy.y,Blade_value));
                break;
            default:
                transform.Rotate(new Vector3(Blade_value,enemy.y, enemy.z));
                break; 



        }
   

       
    }
}
