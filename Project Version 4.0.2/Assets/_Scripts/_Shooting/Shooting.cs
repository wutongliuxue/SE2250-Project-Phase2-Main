using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
/*
 * Student Name: Theodoros Kassa Aragie
 * Student Number: 251163893
 * Goal: Make the gun shoot bullets
 */
public class Shooting : MonoBehaviour
{
    //Defining the bullet:
    public GameObject bullet;//bullet object
    public float shootForce = 125;//bullet force
    public float upwardForce = 1;

    //Other references:
    public Transform attackPoint;//attacking direction reference

    //Called each frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {//if fire key (F) is held down (one bullet per fire)
            ShootBullet();
        }
    }

    //Method to fire bullets:
     private void ShootBullet() {
        //Find exact hit position via raycasting:
        Ray ray = UnityEngine.Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;//tracks when the object hit the target

        //check if the ray hit something:
        Vector3 targetPoint;
        if(Physics.Raycast(ray, out hit)) targetPoint = hit.point;//set target point to the point hit by the ray
        else targetPoint = ray.GetPoint(100);//target point is far from player to prevent themselves from getting hit

        //calculate the direction from the point of attack to the target point:
        Vector3 direction = targetPoint - attackPoint.position;

        //instantiate bullet:
        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);

        //rotate bullet to shoot in the correct direction:
        currentBullet.transform.forward = direction.normalized;

        //add forces to bullet:
        currentBullet.GetComponent<Rigidbody>().AddForce(direction.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(UnityEngine.Camera.main.transform.up * upwardForce, ForceMode.Impulse);

     }
}