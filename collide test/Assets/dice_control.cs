using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice_control : MonoBehaviour
{
    // Start is called before the first frame update
    // 코드 흐름은 항상 선언 < 초기화 < 흐름

    Rigidbody rd; // 선언

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.AddForce(Vector3.up * 10, ForceMode.Impulse); // ForceMode는 힘을 주는 방식, 캐릭터 점프를 이것으로 구현하는편

        
    }

    // Update is called once per frame
    void FixedUpdate() // 물리현상에 대한 업데이트는 FixedUpdate, rigidbody는 모두 이걸로 작성
    {
        // 속력바꾸기
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
