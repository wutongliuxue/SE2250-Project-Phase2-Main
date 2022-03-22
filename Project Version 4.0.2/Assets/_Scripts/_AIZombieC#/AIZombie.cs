using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIZombie : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject RightFist;
    public GameObject LeftFist;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    public void activatePunsh(){
        RightFist.GetComponent<Collider>().enabled = true;
        LeftFist.GetComponent<Collider>().enabled = true;

    }
    public void deactivatePunsh(){
        RightFist.GetComponent<Collider>().enabled = false;
        LeftFist.GetComponent<Collider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
        if (enemy.remainingDistance<4f)
        {
            GetComponent<Animator>().SetTrigger("Attack");
            
        }
    }
}
