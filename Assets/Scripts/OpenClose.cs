using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    public Animator animator;
    public KeyCode Keyboard;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Keyboard))
        {
            if(animator.GetInteger("EtatAnim")==1)
            {
                animator.SetInteger("EtatAnim", 2);

            }
            else
            {
                animator.SetInteger("EtatAnim", 1);
            }
        }
        
    }
}
