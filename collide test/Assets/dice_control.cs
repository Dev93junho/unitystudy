using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice_control : MonoBehaviour
{
    // Start is called before the first frame update
    // �ڵ� �帧�� �׻� ���� < �ʱ�ȭ < �帧

    Rigidbody rd; // ����

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.AddForce(Vector3.up * 10, ForceMode.Impulse); // ForceMode�� ���� �ִ� ���, ĳ���� ������ �̰����� �����ϴ���

        
    }

    // Update is called once per frame
    void FixedUpdate() // �������� ���� ������Ʈ�� FixedUpdate, rigidbody�� ��� �̰ɷ� �ۼ�
    {
        // �ӷ¹ٲٱ�
        // rd.velocity = Vector3.forward;
        if (Input.GetButton("Jump"))
        {
            rd.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rd.velocity);
        }

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rd.AddForce(vec, ForceMode.Impulse);


    }
}
