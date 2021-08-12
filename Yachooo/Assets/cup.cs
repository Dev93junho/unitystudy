using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    Vector3 initPos = new Vector3(0, 0f, 0);
    Vector3 targPos = new Vector3(-1, 0f, 0);
    float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    float x;
    float y;
    float z;
    

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "dice")
        {
            Debug.Log("Prepared to play!!!");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("p")) z= 1-z;

        //modifying the Vector3, based on input multiplied by speed and time
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;

        //apply the change to the gameObject
        transform.localEulerAngles = currentEulerAngles;

        void OnCollisionStay(Collision other)
        {
            if (other.gameObject.tag != "dice")
            {
                if (Input.GetKeyDown("p")) {
                    currentEulerAngles -= new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;
                    transform.localEulerAngles = currentEulerAngles;
                }
            }
        }
    }
}
