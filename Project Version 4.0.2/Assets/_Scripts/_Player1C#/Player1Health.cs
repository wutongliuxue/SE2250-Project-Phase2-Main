using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Health : MonoBehaviour
{
    public float curHealth;
    public float maxHealth;
    public Slider healthBar;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        healthBar.value = curHealth;
        healthBar.maxValue = maxHealth;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float hit = animator.GetFloat("Hit");
        if(curHealth > 0)
        {
            hit -= Time.deltaTime * 3;
        animator.SetFloat("Hit",hit);
        }
        if(curHealth < 1)
        {
            animator.SetBool("Death",true);
        }
        if(Input.GetKeyUp(KeyCode.G))
        {
            SendDamage(Random.Range(10,20));
        }

        
    }
    public void SendDamage(float damageValue)
    {
        curHealth -= damageValue;
        healthBar.value = curHealth;
         animator.SetFloat("Hit",1);
    }
}
