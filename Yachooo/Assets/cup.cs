using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    Vector3 target = new Vector3(-2, 0f, 0);
    Vector3 rotTarget =  new Vector3(0, 0 ,112f);

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
            transform.position = Vector3.MoveTowards(transform.position, target, 0.03f);
            Debug.Log("complete move to goal");
        }
        if (Input.GetKey("r"))
        {
            transform.rotation = Quaternion.Euler(transform.rotation, rotTarget, Time.deltaTime);
        }
    }
}
