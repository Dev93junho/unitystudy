using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
    }
    
    void Update()
    {
      /*  if (Input.anyKeyDown)
            Debug.Log("왜 눌렀니"); */

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점핑!점핑!에블바리");
    }

 
}
