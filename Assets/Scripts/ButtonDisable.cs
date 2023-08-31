using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDisable : MonoBehaviour
{
    public GameObject pickupBtn, DropBtn, Ignore;
    public string Tagname;
    public bool hit;
    public GameObject car;
    public GameObject Explotion;
    public GameObject HitExplotion;


    public int Hittingcount;
    public bool Acpet = true;
   
    private void Start()
    {
        pickupBtn.SetActive(false);
        DropBtn.SetActive(false);
        Ignore.SetActive(false);

       
    }
    

    public IEnumerator LoadUberSceneWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Uber");
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
                Ignore.SetActive(false);
                DropBtn.SetActive(true);
            }
            else
            {
                DropBtn.SetActive(false);
                pickupBtn.SetActive(true);
                Ignore.SetActive(true);
            }  
        }
        else 
        {
            pickupBtn.SetActive(false);
            Ignore.SetActive(false);
            DropBtn.SetActive(false);
        }    
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HitCount"))
        {          
                Hittingcount++;

            GameObject CoinEX1 = Instantiate(HitExplotion, transform.position, Quaternion.identity);
            Destroy(CoinEX1, 1f);
            if (Hittingcount >= 6)           {
               
                Explotion.SetActive(true);
                SpawnPolice.instance.ButtonDisable();
              
                // StartCoroutine(LoadUberSceneWithDelay(2f));
                // SceneManager.LoadScene("Uber");
                //Destroy(car, 2f);

            } 
        }
    }

    
}
