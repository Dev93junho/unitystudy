using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*   // 1. MoveTowards
           transform.position =
               Vector3.MoveTowards(transform.position, target, 1f);  //MoveTowards: ����̵� */

        /* // 2. SmoothDamp
         Vector3 velo = Vector3.up * 5;

         transform.position =
             Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); // ref : ��������, �ǽð����� �ٲ�°� ���밡�� */

        /* // 3. Lerp
        transform.position =
            Vector3.Lerp(transform.position, target, 0.005f);  */

        // 4. SLerp �����
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f * Time.deltaTime);
        
        // deltaTime�� Translate�� �����ϸ� ���Ϳ� ���ϰ�, Vector�Լ��� �����ϸ� �ð� �Ű������� ���ض�
    }
}