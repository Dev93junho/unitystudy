using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
  /*  void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() //반복적으로 사용하는 것을 활성화 시킴
    {
        Debug.Log("플레이어가 로그인 했습니다");
    }

    void Start() //업데이트 직전에 최초실행
    {
        Debug.Log("사냥 장비를 챙겼습니다");
    }

    void FixedUpdate()
    {
        Debug.Log("이동~");

    }

    // Game Logic Step
    void Update() //주기적으로 변하는 설정을 넣을때
    {
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate() // 모든 업데이트가 끝난 후, 로직의 후처리를 담당함
    {
        Debug.Log("경험치 획득");
    }

    void OnDisable() //오브젝트가 비활성화 
    {
        Debug.Log("플레이어가 로그아웃 했습니다");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다");
    }  */

    /* void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입하였습니다");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동중");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었습니다");
        }
    } */


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("방구뀔거야");
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("방구 모으는중....");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("뿌우우웅");
        }

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxis("Vertical"));
        }
    }

    
}
