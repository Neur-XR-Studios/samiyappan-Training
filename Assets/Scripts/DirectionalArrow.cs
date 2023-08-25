using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DirectionalArrow : MonoBehaviour
{
    public static DirectionalArrow instance;
    [SerializeField]
    public GameObject target;
    private Spawning spaning;
    public bool arrowDetect;
    public GameObject G1;

    public void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private  void Update()
    {
        DetectArrow();
        if (arrowDetect == true)
        {
            G1 =GameObject.Find("Arrow");

            target = GameObject.Find("A1 1");
            Vector3 targetPos = target.transform.position;
            targetPos.y = transform.position.y;
            transform.LookAt(targetPos);
        }
        else
        {
            //
        }
    }
    public void DetectArrow()
    {
        arrowDetect = true;
    }
    public void DArrow()
    {
        arrowDetect = false;
    }
}
