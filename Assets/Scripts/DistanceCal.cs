using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DistanceCal : MonoBehaviour
{
    public GameObject Carpoint;
    public GameObject Endpoint;
    public float DistanceValue;
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
        DistanceCalculation();
        distanceValueText.text = DistanceValue.ToString();
    }
    void DistanceCalculation()
    {
        DistanceValue = Vector3.Distance(Carpoint.transform.position, Endpoint.transform.position);
    }
}
