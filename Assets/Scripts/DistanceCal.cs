using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;
using System;
public class DistanceCal : MonoBehaviour
{
    public GameObject Carpoint;
    public GameObject Endpoint;
    public  static float  DistanceValue;
 
    public GameObject distanceValue;
    public TMP_Text distanceValueText;
    
    private void Start()
    {
        Carpoint = GameObject.Find("Customer");      
        distanceValue = GameObject.Find("Distance");
        distanceValueText = distanceValue.GetComponent<TMP_Text>();
      
    }   
    void Update()
    {
        int roundedValue = Mathf.RoundToInt(DistanceValue);      
        DistanceCalculation();
        distanceValueText.text = roundedValue.ToString();
        /* Debug.Log(roundedValue);
       Debug.Log(DistanceValue);*/
    }
    void DistanceCalculation()
    {
       
        DistanceValue = Vector3.Distance(Carpoint.transform.position, Endpoint.transform.position);
    }
}