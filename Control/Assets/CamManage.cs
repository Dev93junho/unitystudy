using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManage : MonoBehaviour
{
    public Camera maincam;
    public Camera subcam;

    bool Cam2 = true; // If you want to switched camera, you would be need to camera discriminator 

    private void MaincamOn()
    {
        maincam.enabled = true;
        subcam.enabled = false;
    }

    private void SubcamOn()
    {
        maincam.enabled = false;
        subcam.enabled = true;
    }

    void Start()
    {
        MaincamOn();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            if (Cam2 == true)
            {
                Cam2 = false;
                SubcamOn();
            }
            else
            {
                Cam2 = true;
                MaincamOn();
            }
        }         
    }
}
