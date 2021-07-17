using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSController : MonoBehaviour
{
    Rigidbody rgd;
    public int scoreCount;
    public bool isFalling = false;


    void Start()
    {
        rgd = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rgd.AddForce(Vector3.up * 100, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Vertical"), 0, -Input.GetAxisRaw("Horizontal"));

        rgd.AddForce(vec , ForceMode.Impulse);
    }
}
