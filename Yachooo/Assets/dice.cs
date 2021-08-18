using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    public GameObject ScoreBoard;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
        }  

        void OnCollisionEnter(Collision other) 
        {
            if (other.gameObject.tag == "Ground")
            {
                ScoreBoard.gameObject.SetActive(True);
            }
            
        }    
    }
}
