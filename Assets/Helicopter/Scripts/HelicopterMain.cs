using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HelicopterMain : MonoBehaviour
{
    public BladeRotate MainBlade;
    public BladeRotate SubBlade;

    public float enginePower;
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
    public float EngineForword = 2f;


  

    public void Update()
    {
       
        if (Input.GetAxis("Height") > 0)
        {
           

            EnginePower += EngineLift;
            float heightIncreaseSpeed = 1.0f;
            transform.Translate(Vector3.up * heightIncreaseSpeed * Time.deltaTime);

            if (EngineLift < 1f)
            {
              transform.Translate(Vector3.forward* EngineForword*Time.deltaTime);

            }
        }
        else
        {
            if(EnginePower < 0)
            {
                EnginePower = 0;
            }
           
            EnginePower -= EngineLift;
            float downvalue = 1.0f;
            transform.Translate(Vector3.down * downvalue * Time.deltaTime);

        }
    }
        
     

}
