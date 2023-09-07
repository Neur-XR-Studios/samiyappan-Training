using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HelicopterMain : MonoBehaviour
{
    public Rigidbody mainRigidbody;
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
    public float EngineForwardThrust = 1.0f;

    public void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetAxis("Height") >0)
        {
            EnginePower += EngineLift;
            float heightIncreaseSpeed = 1.0f; 
            transform.position += Vector3.up * heightIncreaseSpeed * Time.deltaTime;
            mainRigidbody.isKinematic = true;
            mainRigidbody.useGravity = false;

            if (EngineLift < 1f)
            {
                transform.Translate(Vector3.forward * EngineForwardThrust * Time.deltaTime);

            }
        }
      
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            mainRigidbody.isKinematic = false;
            mainRigidbody.useGravity = true;
            MainBlade.BladeSpeed = 0f;
            SubBlade.BladeSpeed=0f;
        }
        else
        {
            EnginePower -= EngineLift;
            float descentSpeed = 1.0f;
            transform.Translate(Vector3.down * descentSpeed * Time.deltaTime);
        }

    }
     

}
