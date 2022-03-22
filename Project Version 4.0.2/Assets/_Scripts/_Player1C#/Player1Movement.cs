using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float jumpHeight;
    private Vector3 moveDirection;
    private Vector3 velocity;
    // [SerializeField] private bool isGrounded;
    // [SerializeField] private float groundCheckDistance;
    // [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;
    private CharacterController controller;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<CharacterController>();
        animator= GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up* Input.GetAxis("Horizontal") *Time.deltaTime* 90);
        Move();
        if(Input.GetKeyDown(KeyCode.J))
        {
             Attack();
        }
       if(Input.GetKeyDown(KeyCode.F))
        {
             FireM1A1();
        }

    } 
    private void Move()
    {
        // isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        // if(isGrounded && velocity.y <0)
        // {
        //     velocity.y = -2f;
        // }

          float moveZ=Input.GetAxis("Vertical");
          moveDirection=new Vector3(0,0,moveZ);
         
        if(moveDirection != Vector3.zero && ! Input.GetKey(KeyCode.LeftShift))
         {
             Walk();
         }else if(moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
         {
             Run();
         }
         else if(moveDirection==Vector3.zero)
         {
             Idle();
         }
         if(Input.GetKeyDown(KeyCode.Space))
         {

             Jump();
         }
         if(Input.GetKeyDown(KeyCode.C))
         {
             Roll();
         }
         moveDirection *=moveSpeed;
        
          moveDirection= transform.TransformDirection(moveDirection);
          
         
         moveDirection *=moveSpeed;
          controller.Move(moveDirection * Time.deltaTime);
          velocity.y +=gravity*Time.deltaTime;
          controller.Move(velocity * Time.deltaTime);
    }

    private void Idle()
    {
      animator.SetFloat("Speed",0,0.1f,Time.deltaTime);
    } 
    private void Walk()
    {
       moveSpeed = walkSpeed;
       animator.SetFloat("Speed",0.5f,0.1f,Time.deltaTime);
    }
    private void Run()
    {
      moveSpeed = runSpeed;
      animator.SetFloat("Speed", 1f,0.1f,Time.deltaTime);
    }

    private void Jump()
    {
       velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
       animator.SetTrigger("Jump");
    }
    private void Attack()
    {
        animator.SetTrigger("Attack");
    }
    private void FireM1A1()
    {
        animator.SetTrigger("Fire");
    }
    private void Roll()
    {
        moveSpeed = runSpeed;
        animator.SetTrigger("Roll");
    }





}
