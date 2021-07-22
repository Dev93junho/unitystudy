using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManageLogic : MonoBehaviour
{
    // Operating Speed will be better than using Find WithTag
    public int totalBallCount;
    public int Stage;
    public Text ScoreText;

    public void GetItem(int count)
    {
        ScoreText.text = count.ToString();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Stage1");
        }


        
    }
}
