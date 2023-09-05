using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PositionChange : MonoBehaviour
{
    public Transform PosCam;
    public Vector3[] Offset;
    


    public void Update()
    {
        PosCam.transform.position = new Vector3(PosCam.position.x, PosCam.position.y, PosCam.position.y);       

    }
   

    public void Onpos(int pos)
    {      
     transform.position = Offset[pos]; 
    }
}
