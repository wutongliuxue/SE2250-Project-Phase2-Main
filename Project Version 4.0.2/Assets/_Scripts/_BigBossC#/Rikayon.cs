﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rikayon : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.J)) {
            animator.SetTrigger("Attack_1");
        }
		else if (Input.GetKeyDown(KeyCode.F)) {
            animator.SetTrigger("Attack_1");
        }
	}
}
