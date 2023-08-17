using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawningObj : MonoBehaviour
{

    public static SpawningObj instance;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
      
    }

    // Update is called once per frame
    public void SPawnPlayer()
    {


        GameObject one = Instantiate(obj,  new Vector3(gameObject.transform.position.x , gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        one.transform.parent = transform;



    }
}
