using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
 
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "dice1") // 충돌효과가 일어날때만
            mat.color = new Color(0, 0, 0); // 검정색임 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "dice2") // 충돌효과가 일어날때만
            mat.color = new Color(1, 1, 1); // 검정색임 
    }


}
