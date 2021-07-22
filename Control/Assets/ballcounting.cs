using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ballcounting : MonoBehaviour
{
    
    public int ballCount;
    public GameManageLogic manager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball") // When "ball" collide to "GameManager" 
        {
            ballCount++;
            other.gameObject.SetActive(false);
            manager.GetItem(ballCount); //Send the score data to score UI in GameManageLogic 
        }
    }
}
