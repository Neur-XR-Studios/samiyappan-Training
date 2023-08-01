using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControll : MonoBehaviour
{
    [SerializeField] WheelCollider FrontR;
    [SerializeField] WheelCollider FrontL;
    [SerializeField] WheelCollider BackR;
    [SerializeField] WheelCollider BackL;


    [SerializeField] Transform T_FrontR;
    [SerializeField] Transform T_FrontL;
    [SerializeField] Transform T_BackR;
    [SerializeField] Transform T_BackL;

    public float acceleration = 500f;
    public float breakforce = 1.0f;
    public float Maxt_Angle = 1.0f;


    private float Currentacceleration = 0f;
    private float Currentbreakforce = 0f;
    private float Currentmaxt_Angle = 0f;

    public void FixedUpdate()
    {
        Currentacceleration = acceleration * Input.GetAxis("Vertical");
        CoinCollections.instance.CarSpeeds();
        if (Currentacceleration != 0)
        {
          
            CoinCollections.instance.Fuel();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Currentbreakforce = breakforce;
        }
        else
        {
            Currentbreakforce = 0f;
        }

        FrontR.motorTorque = Currentacceleration;
        FrontL.motorTorque = Currentacceleration;

        FrontR.brakeTorque = Currentbreakforce;
        FrontL.brakeTorque = Currentbreakforce;
        BackR.brakeTorque = Currentbreakforce;
        BackL.brakeTorque = Currentbreakforce;

        Currentmaxt_Angle = Maxt_Angle * Input.GetAxis("Horizontal");
        {
           
        }

        FrontR.steerAngle = Currentmaxt_Angle;
        FrontL.steerAngle = Currentmaxt_Angle;

        Wheelpos(FrontR, T_FrontR);
        Wheelpos(BackL, T_BackL);
        Wheelpos(FrontL, T_FrontL);
        Wheelpos(BackR, T_BackR);

    }
    void Wheelpos(WheelCollider col ,Transform transform)
    {
        Vector3 position;

        Quaternion rotation;

        col .GetWorldPose (out position, out rotation);

        transform.position = position;
        transform.rotation = rotation;
    }
}