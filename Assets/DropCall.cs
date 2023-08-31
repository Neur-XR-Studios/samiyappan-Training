using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCall : MonoBehaviour
{
    public GameObject myGameObject;

    
    private void Update()
    {
        myGameObject = GameObject.Find("DropSpawn");
    }
    public void D1()
    {

        SpawningObj myComponent = myGameObject.GetComponent<SpawningObj>();
        if (myComponent != null)
        {
           
            myComponent.SPawnPlayer(0);
        }
    }
}
