using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControll : MonoBehaviour
{
    [SerializeField] WheelCollider FR;
    [SerializeField] WheelCollider FL;
    [SerializeField] WheelCollider BR;
    [SerializeField] WheelCollider BL;


    [SerializeField] Transform T_FR;
    [SerializeField] Transform T_FL;
    [SerializeField] Transform T_BR;
    [SerializeField] Transform T_BL;

    public float acceleration = 500f;
    public float breakforce = 1.0f;
    public float Maxt_Angle = 1.0f;


    private float Currentacceleration = 0f;
    private float Currentbreakforce = 0f;
    private float Currentmaxt_Angle = 0f;

    public void FixedUpdate()
    {
        Currentacceleration = acceleration * Input.GetAxis("Vertical");
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

        FR.motorTorque = Currentacceleration;
        FL.motorTorque = Currentacceleration;

        FR.brakeTorque = Currentbreakforce;
        FL.brakeTorque = Currentbreakforce;
        BR.brakeTorque = Currentbreakforce;
        BL.brakeTorque = Currentbreakforce;


        Currentmaxt_Angle = Maxt_Angle * Input.GetAxis("Horizontal")   ;

        FR.steerAngle = Currentmaxt_Angle;
        FL.steerAngle = Currentmaxt_Angle;


        Wheelpos(FR, T_FR);
        Wheelpos(BL, T_BL);
        Wheelpos(FL, T_FL);
        Wheelpos(BR, T_BR);


    }


    void Wheelpos(WheelCollider col ,Transform transform)
    {
        Vector3 position;

        Quaternion rotation;

        col .GetWorldPose (out position, out rotation);

        transform.position = position;
        transform.rotation = rotation;
    }




































































    /*
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
            if (_verticalInput!=0) 
            {            
                CoinCollections.instance.Fuel();
            }
           // Debug.Log(_verticalInput);

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
        }*/



}
 
