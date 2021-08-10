using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    public Vector3 cupPos;


    void Start() 
    {
        cupPos = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "dice")
        {
            Debug.Log("Prepared to play!!!");
        }
    }
    void Update()
    {
        if (Input.GetKey("p"))
        {
            cupPos = new Vector3(-5, 0, 0);
        }

        
    }
}
