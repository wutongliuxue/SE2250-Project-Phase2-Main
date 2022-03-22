using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   [SerializeField] private float mouseSensitivity;
   private Transform parent;



    // public Vector3 cameraOffset;
    // public Transform targetObject;
    // public float smoothFactor = 0.5f;
    // public bool lookAtTarget = false;
   
    private void Start()
    {
       parent = transform.parent;
       Cursor.lockState = CursorLockMode.Locked;
        // cameraOffset= transform.position - targetObject.transform.position;
    }

   
    private void Update()
    {

         Rotate(); 

    //     Vector3 newPosition = targetObject.transform.position + cameraOffset;
    //     transform.position= Vector3.Slerp(transform.position,newPosition,smoothFactor);
    //   if(lookAtTarget) 
    //   {
    //       transform.LookAt(targetObject);
    //   } 
    }
    private void Rotate()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity*Time.deltaTime;
       parent.Rotate(Vector3.up, mouseX);
    }
}
