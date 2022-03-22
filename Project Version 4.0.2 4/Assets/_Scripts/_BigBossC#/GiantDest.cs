using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantDest : MonoBehaviour
{

    public int pivotPoint;

    void OnTriggerEnter(Collider other){

        if(other.tag == "Giant"){

            if(pivotPoint == 6){
                pivotPoint = 0;
            }
            if(pivotPoint == 5){
                this.gameObject.transform.position = new Vector3(490, 5, 550);
                pivotPoint = 6;
            }
            if(pivotPoint == 4){
                this.gameObject.transform.position = new Vector3(519, 5, 527);
                pivotPoint = 5;
            }
            if(pivotPoint == 3){
                this.gameObject.transform.position = new Vector3(578, 5, 531);
                pivotPoint = 4;
            }
            if(pivotPoint == 2){
                this.gameObject.transform.position = new Vector3(681, 5, 491);
                pivotPoint = 3;
            }
            if(pivotPoint == 1){
                this.gameObject.transform.position = new Vector3(578, 5, 580);
                pivotPoint = 2;
            }
            if(pivotPoint == 0){
                this.gameObject.transform.position = new Vector3(490, 5, 550);
                pivotPoint = 1;
            }
        }
    }
}
