using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject pickupBtn, DropBtn, Ingnore;
    public string Tagname;
    public bool hit;




    private void Start()
    {
        pickupBtn.SetActive(false);
        DropBtn.SetActive(false);
        Ingnore.SetActive(false);
    }
    public void Update()
    {
        UpdateDistance();
    }
    public void UpdateDistance()
    {

        if (DistanceCal.DistanceValue > 0 && DistanceCal.DistanceValue < 2)
        {      
            if(AcceptIgnore.Accept)
            {
                
                DropBtn.SetActive(true);

            }
            else
            {
                pickupBtn.SetActive(true);
                Ingnore.SetActive(true);
            
            }
        }
        else 
        {
            pickupBtn.SetActive(false);
            Ingnore.SetActive(false);
            DropBtn.SetActive(false);
        }





    }
 
}
