using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HelicopterMain : MonoBehaviour
{
    public BladeRotate MainBlade;
    public BladeRotate SubBlade;

    private float enginePower;
    public float EnginePower
    {
        get
        {
            return enginePower;
        }
        set
        {
            MainBlade.BladeSpeed = value * 250;
            SubBlade.BladeSpeed = value * 500;
            enginePower = value;
        }
    }
    public float EngineLift = 0.1f;



     void Update()
    {
        if (Input.GetAxis("Height") >0)
        {
            EnginePower += EngineLift;
            float heightIncreaseSpeed = 1.0f; 
            transform.position += Vector3.up * heightIncreaseSpeed * Time.deltaTime;
        }
        else if(Input.GetAxis("Height") < 0)
        {
            EngineLift = 0f;
        }
    }
     

}
