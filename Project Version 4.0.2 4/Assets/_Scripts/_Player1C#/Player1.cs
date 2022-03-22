using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    [SerializeField] public float speed;
    private Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = speed*Vector3.forward  * Input.GetAxis("Vertical");
         
        transform.Translate(velocity *Time.deltaTime);
   
        //  transform.Translate(speed*Vector3.right  * Input.GetAxis("Horizontal")*Time.deltaTime);
        transform.Rotate(Vector3.up* Input.GetAxis("Horizontal") *Time.deltaTime* 90);
        animator.SetFloat("speed", velocity.z);
        
    }
    void FixedUpdate()
    { 
        
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        
        // Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);

        
        // GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    
    }
}
