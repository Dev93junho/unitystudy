using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    Vector3 target = new Vector3(-2, -32, 72);

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
            transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        }
        if (Input.GetKey("r"))
        {
            transform.rotation = Quaternion.Euler(new Vector3(10,0,0));
        }
    }
}
