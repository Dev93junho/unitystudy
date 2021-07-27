using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OncollisionEnter(Collision collision) // If collision input
    {
    
    }

}
