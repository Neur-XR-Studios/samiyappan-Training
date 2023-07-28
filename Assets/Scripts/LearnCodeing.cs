using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCodeing : MonoBehaviour
{

    ///for loop
    ///for each
    ///Array
    ///swith
    ///if




    public void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }


    }
    private void Update()
    {
        int Counts = 10;
        int[] apples = { 1, 2, 3, 4, 5, };
        foreach (int count in apples)
        {

            Debug.Log(count);
        }

        int day = 3;
        switch (day)
        {
            case 1:
                Debug.Log("ds");
                break;
            case 2:
                Debug.Log("kk");
                break;
            default:
                break;
        }

        if (Counts > 0)
        {
            Debug.Log(Counts);
        }

    }







}
