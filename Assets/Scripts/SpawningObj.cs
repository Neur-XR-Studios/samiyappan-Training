using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawningObj : MonoBehaviour
{

    public static SpawningObj instance;
    public GameObject[] obj;
    // Start is called before the first frame update
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
        if(SelectIndex <0 || SelectIndex >= obj.Length)
        {
            return;
        }
        GameObject SpawnObjeCt = Instantiate(obj[SelectIndex],  new Vector3(gameObject.transform.position.x , gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        SpawnObjeCt.transform.parent = transform;
    }
}
