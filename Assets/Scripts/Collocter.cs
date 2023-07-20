using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collocter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy_T") || collision.CompareTag("Player")) 
        {

            Destroy(collision.gameObject);
        }
    }
}
