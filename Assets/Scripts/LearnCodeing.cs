using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCodeing : MonoBehaviour
{
    PlayerTest sam;
    PlayerTest magu;

    public void Start()
    {

        sam = new PlayerTest( 10,"sam",100f);
        magu = new PlayerTest (100, "magu", 1000f);
        sam.Info();
        magu.Info();
        magu .Attack();
        sam.Attack();

    }



}
