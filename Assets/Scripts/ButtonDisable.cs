using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject pickupBtn, DropBtn, Ingnore;
    public string Tagname;
    public bool hit;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(Tagname))
        {
            if (hit)
            {
                pickupBtn.SetActive(true);
                Ingnore.SetActive(true);
                DropBtn.SetActive(false);
                hit = false;
            }
            else
            {
                pickupBtn.SetActive(false);
                Ingnore.SetActive(false);
                DropBtn.SetActive(true);
                hit = true;
            }
        }
    }

    public void trueHit(bool IsHit)
    {
        hit = IsHit;
    }




















    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}//class
