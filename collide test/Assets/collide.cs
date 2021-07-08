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
        if (collision.gameObject.name == "dice1") // �浹ȿ���� �Ͼ����
            mat.color = new Color(0, 0, 0); // �������� 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "dice2") // �浹ȿ���� �Ͼ����
            mat.color = new Color(1, 1, 1); // �������� 
    }


}
