using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControll : MonoBehaviour
{
    public Rigidbody carObject;
    public static CarControll instance;
     
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
    public static float Currentbreakforce = 0f;
    private float Currentmaxt_Angle = 0f;

    public TMP_Text CarSpeed;
    public float CarSpeedvalue = 0;
    int CarSpeedmax = 0;

    private bool CarSpawns = true;
    private bool CarSpawns2 = true;

    public GameObject siren;

    public GameObject PoliceCar;
    public void Start()
    {
       // CarSpeed = transform.Find("CarSpeed").GetComponent<TMP_Text>();

        carObject.GetComponent<Rigidbody>();
        if (instance == null)
        {
            instance =this;
        }
    }
    //public AudioSource CarSpeedaudio;
    public void FixedUpdate()
    {
       
        CarMove();
        Carturn();
    }
    public void Carturn()
    {

        Currentmaxt_Angle = Maxt_Angle * Input.GetAxis("Horizontal");
        {

        }

        FrontR.steerAngle = Currentmaxt_Angle;
        FrontL.steerAngle = Currentmaxt_Angle;
    }
        
    public void CarMove()
    {

        PoliceCar = GameObject.Find("PoliceCar(Clone)");
        Currentacceleration = acceleration * Input.GetAxis("Vertical");

        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            CarSpeedvalue = CarSpeedvalue + (5 * Time.deltaTime);
            CarSpeedmax = (int)(CarSpeedvalue);
            CarSpeed.text = CarSpeedmax.ToString();

        }

        else
        {
            if (CarSpeedvalue > 0)
            {
                CarSpeedvalue = CarSpeedvalue - (5 * Time.deltaTime);
                CarSpeedmax = (int)(CarSpeedvalue);
                CarSpeed.text = CarSpeedmax.ToString();
                // StartWheel();
            }
            else if (CarSpeedvalue > 80)
            { 
                    //
            }
        }

     

        // siren sound


        if (CarSpeedvalue >= 60)
        {
            siren.gameObject.SetActive(true);

            // CarSpawns = true;
            if (CarSpeedvalue >= 90 && CarSpawns == true)
            {
                SpawnPolice.instance.PoliceSpawning();
                CarSpawns = false;
                CarSpawns2 = true;


            }
           /* else if (CarSpeedvalue <= 90 && CarSpawns2 == true)
            {
                Destroy(PoliceCar);
                CarSpawns2=false;
                CarSpawns = true;

            }   */

        }
        else
        {

            siren.gameObject.SetActive(false);

        }

        



        // Fuel Feilling
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

       

        Wheelpos(FrontR, T_FrontR);
        Wheelpos(BackL, T_BackL);
        Wheelpos(FrontL, T_FrontL);
        Wheelpos(BackR, T_BackR);

    }
    void Wheelpos(WheelCollider col, Transform transform)
    {
        Vector3 position;

        Quaternion rotation;

        col.GetWorldPose(out position, out rotation);

        transform.position = position;
        transform.rotation = rotation;
    }

  /*  public void StopWheel()
    {

        carObject.constraints = RigidbodyConstraints.FreezePosition;     


    }

    public void StartWheel()
    {
        carObject.constraints = RigidbodyConstraints.FreezeAll;
    }*/
    

}           