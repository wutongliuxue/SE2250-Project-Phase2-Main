using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantAI : MonoBehaviour
{
   
    public GameObject Giant;
    public Animator animator;


    void Start(){
        animator = GetComponent<Animator>();
    }

    void onTriggerEnter(Collider other){
       animator.SetTrigger("Attack_1");
    }

    void onTriggerExit(Collider other){
        animator.SetTrigger("Rest");
    }
}
