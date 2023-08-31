using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawningObj : MonoBehaviour
{

    public static SpawningObj instance;
    public GameObject[] SpawnCar;
    public int selectedIndex = -1;
   

   
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
      
    }
  

    // Update is called once per frame
    public void SPawnPlayer(int  SelectIndex)
    {
        if(SelectIndex <0 || SelectIndex >= SpawnCar.Length)
        {
            return;
        }
        selectedIndex = SelectIndex;
        GameObject SpawnObjeCt = Instantiate(SpawnCar[SelectIndex],  new Vector3(gameObject.transform.position.x , gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        SpawnObjeCt.transform.parent = transform;
    }

    public void Respawn()
    {
        if(selectedIndex != -1)
        {
            Destroy(transform.GetChild(0).gameObject);
            SPawnPlayer (selectedIndex);
        }
    }
   
}
