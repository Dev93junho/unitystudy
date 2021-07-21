using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManageLogic : MonoBehaviour
{
    // Operating Speed will be better than using Find WithTag
    public int totalBallCount;
    public GameManageLogic manager;
    public int stage;
    public int ballCount;
    public Text stageCountText;
    public Text playerCountText;

    void Awake()
    {
        stageCountText.text = "/" + totalBallCount.ToString();
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {

        } else if (other.gameObject.tag == "FinishPoint")
        {
            if (ballCount == manager.totalBallCount) ;
                
        }
    }
}
