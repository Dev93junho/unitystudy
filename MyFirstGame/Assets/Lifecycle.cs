using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
  /*  void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable() //�ݺ������� ����ϴ� ���� Ȱ��ȭ ��Ŵ
    {
        Debug.Log("�÷��̾ �α��� �߽��ϴ�");
    }

    void Start() //������Ʈ ������ ���ʽ���
    {
        Debug.Log("��� ��� ì����ϴ�");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�~");

    }

    // Game Logic Step
    void Update() //�ֱ������� ���ϴ� ������ ������
    {
        Debug.Log("���� ���!");
    }

    void LateUpdate() // ��� ������Ʈ�� ���� ��, ������ ��ó���� �����
    {
        Debug.Log("����ġ ȹ��");
    }

    void OnDisable() //������Ʈ�� ��Ȱ��ȭ 
    {
        Debug.Log("�÷��̾ �α׾ƿ� �߽��ϴ�");
    }

    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�");
    }  */

    /* void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("�������� �����Ͽ����ϴ�");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵���");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("������ �̵��� ���߾����ϴ�");
        }
    } */


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("�汸��ž�");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("�汸 ��������....");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("�ѿ���");
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxis("Vertical"));
        }
    }

    
}
