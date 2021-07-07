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
               Vector3.MoveTowards(transform.position, target, 1f);  //MoveTowards: 등속이동 */

        /* // 2. SmoothDamp
         Vector3 velo = Vector3.up * 5;

         transform.position =
             Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); // ref : 참조접근, 실시간으로 바뀌는값 적용가능 */

        /* // 3. Lerp
        transform.position =
            Vector3.Lerp(transform.position, target, 0.005f);  */

        // 4. SLerp 곡선보간
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f * Time.deltaTime);
        
        // deltaTime은 Translate에 적용하면 벡터에 곱하고, Vector함수에 적용하면 시간 매개변수에 곱해라
    }
}
