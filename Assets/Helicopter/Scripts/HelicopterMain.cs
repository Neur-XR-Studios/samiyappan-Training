using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public float EngineLift = 0.0075f;



     void Update()
    {
        if (Input.GetAxis("Horizontal") >0)
        {
            EnginePower += EngineLift;
        }
    }

}
