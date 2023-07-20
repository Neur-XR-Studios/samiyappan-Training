using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickp : MonoBehaviour
{
    public Spawning spawn;
    public GameObject SpawnObj;
    public GameObject Pickupbutton;
    public GameObject Ignorebutton;
    public GameObject DropButton;
    public GameObject Pickupbutton1;
    public GameObject Ignorebutton2;
    public GameObject DropButton3;




    public void Start()
    {

        Pickupbutton = GameObject.Find("Pickup");       
        DropButton = GameObject.Find("Drop");
        Ignorebutton = GameObject.Find("Ignore");


        SpawnObj = GameObject.Find("SpawningObjects");


        Pickupbutton1 = GameObject.Find("PickupT");
        DropButton3 = GameObject.Find("DropT");
        Ignorebutton2 = GameObject.Find("IgnoreT");


        spawn = SpawnObj.GetComponent<Spawning>();
        Pickupbutton.GetComponent<Button>(); 
        DropButton.GetComponent<Button>();
        Ignorebutton.GetComponent<Button>();



        Pickupbutton.GetComponent<Image>();
        DropButton.GetComponent<Image>();
        Ignorebutton.GetComponent<Image>();


        Pickupbutton1.GetComponent<TextMeshProUGUI>();
        DropButton3.GetComponent<TextMeshProUGUI>();
        Ignorebutton2.GetComponent<TextMeshProUGUI>();




        /*Ignorebutton.SetActive(false);
        DropButton.SetActive(false);
        Pickupbutton.SetActive(false);
*/


        










    }
    private void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Customer")
        {

            Pickupbutton.GetComponent<Button>().enabled = true ;            
            DropButton.GetComponent<Button>().enabled = false;
            Ignorebutton.GetComponent<Button>().enabled = true;

            Pickupbutton.GetComponent<Image>().enabled = true;
            DropButton.GetComponent<Image>().enabled = false;
            Ignorebutton.GetComponent<Image>().enabled = true;

            Pickupbutton1.GetComponent<TextMeshProUGUI>().enabled = true;
            DropButton3.GetComponent<TextMeshProUGUI>().enabled = false;
            Ignorebutton2.GetComponent<TextMeshProUGUI>().enabled = true;


        }


    }
    public void Ignore()
    {

       
        spawn.Spawn();
        Destroy(gameObject, 10);



    }
    public void Drop()
    {
        Pickupbutton.GetComponent<Button>().enabled = true;
        DropButton.GetComponent<Button>().enabled = false;
        Ignorebutton.GetComponent<Button>().enabled = true;

        Pickupbutton.GetComponent<Image>().enabled = true;
        DropButton.GetComponent<Image>().enabled = false;
        Ignorebutton.GetComponent<Image>().enabled = true;

        Pickupbutton1.GetComponent<TextMeshProUGUI>().enabled = true;
        DropButton3.GetComponent<TextMeshProUGUI>().enabled = false;
        Ignorebutton2.GetComponent<TextMeshProUGUI>().enabled = true;
        spawn.Spawn();
        Destroy(gameObject);
      





    }
    public void Pickup()
    {

        Pickupbutton.GetComponent<Button>().enabled = false;
        DropButton.GetComponent<Button>().enabled = true;
        Ignorebutton.GetComponent<Button>().enabled = false;

        Pickupbutton.GetComponent<Image>().enabled = false;
        DropButton.GetComponent<Image>().enabled = true;
        Ignorebutton.GetComponent<Image>().enabled = false;

        Pickupbutton1.GetComponent<TextMeshProUGUI>().enabled = false;
        DropButton3.GetComponent<TextMeshProUGUI>().enabled = true;
        Ignorebutton2.GetComponent<TextMeshProUGUI>().enabled = false;
        spawn.Spawn();
        Destroy(gameObject);








    }



}
