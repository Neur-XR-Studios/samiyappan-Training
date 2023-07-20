using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControll : MonoBehaviour
{

    private float _horizontalInput;
    private float _verticalInput;
    private float _steerAngle;
    private  float _BreakForce;
    

    public WheelCollider front_Wl, front_WR, back_Wl, back_WR;
    public Transform front_TL, front_TR, back_TL, back_TR;

    public float MotorForce = 60f;
    public float MaxsteerAngle = 15f;
    public float BreakForce = 100f;
  


    public void Start()
    {
        
       
    }


    private void FixedUpdate()
    {
        _Input();
        _SteerAngle();
        Accelerator();
        WheelPos();
     

    }
    private void Update()
    {
        A1();
    }
    public void A1()
    {
        if(Input.GetKey(KeyCode.Space))
        {

           
            front_Wl.brakeTorque = BreakForce * MotorForce;
            front_WR.brakeTorque = BreakForce * MotorForce;

        }
        else
        {        
            front_Wl.brakeTorque = _BreakForce * MotorForce;
            front_WR.brakeTorque = _BreakForce * MotorForce;        


        }
    }
    private void _Input()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }
    private void _SteerAngle()
    {
        _steerAngle = MaxsteerAngle * _horizontalInput;

        front_Wl.steerAngle = _steerAngle;
        front_WR.steerAngle = _steerAngle;
    }
   
    private void Accelerator()
    {
        front_Wl.motorTorque = _verticalInput * MotorForce;
        front_WR.motorTorque = _verticalInput * MotorForce;
    }
    private  void WheelPos()
    {
        WheelPosition(front_WR, front_TR);
        WheelPosition(front_Wl, front_TL);
        WheelPosition(back_Wl, back_TL);
        WheelPosition(back_WR, back_TR);


    }
    private void WheelPosition( WheelCollider _Collider, Transform _Transform )
    {   
        Vector3  _pos = transform.position;
        Quaternion _Quat = _Transform.rotation;
         

        _Collider.GetWorldPose(  out _pos,out  _Quat);

        _Transform.position = _pos;
        _Transform.rotation = _Quat;
    }
    


}
 
