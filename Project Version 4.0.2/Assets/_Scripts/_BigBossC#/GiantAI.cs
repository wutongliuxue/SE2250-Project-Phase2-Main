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

    void OnCollisionEnter(Collision collision){

        

        if(collision.gameObject.tag == "Player")
        {
           animator.SetTrigger("Attack_1");
           
        }
    }

   
}
