using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Student Name: Tong Wu
   Student Number: 251155168
   Goal: Switch Scene (From Game Start UI to Game Scene)
*/


public class SwitchScene : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
