using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicStick : MonoBehaviour
{
    public Vector3 prePos;
    public Vector3 currentPos;
    public Vector3 distance;
    public Vector3 Velocity;
    


    void Start() 
    {
        prePos = new Vector3(10f,1000,10f);    
    }

    void Update() 
    {
        currentPos = transform.position;
        distance = (currentPos - prePos);
        prePos = currentPos;
        Velocity = distance / Time.deltaTime;   
    }

    void OnTriggerEnter(Collider other) 
    {
        if (Velocity.x == 0f && Velocity.y == 0f && Velocity.z == 0f)
        {
            if (other.gameObject.tag == "ScoreBoard")
            {
                Debug.Log(this.gameObject.name);
            }
        }
        
    }
}
