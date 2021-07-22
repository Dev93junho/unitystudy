using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameManageLogic manager;
    public ballcounting ballcount;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            {
                if (ballcount.ballCount == manager.totalBallCount)
                {
                    Debug.Log("EndingScene");
                    SceneManager.LoadScene("EndingScene");
                }
                else
                {
                    //restart
                    SceneManager.LoadScene("Stage1");
                }
            }
    }

}
