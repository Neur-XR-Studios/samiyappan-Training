using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject pickupBtn, DropBtn, Ingnore;
    public string Tagname;
    public bool hit;
    public bool Acpet = true;




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


            if (AcceptIgnore.Accept)
            {
                pickupBtn.SetActive(false);
                Ingnore.SetActive(false);
                DropBtn.SetActive(true);
              
               

            }
            else
            {
                DropBtn.SetActive(false);
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
