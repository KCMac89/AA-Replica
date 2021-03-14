using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 10.0f;
    public float timeRemaining;

 
    void Start()
    {
        timeRemaining = timelimit;

        timeLimitText.text = "Time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
    }



    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0 )
        {
            remainingTimeText.text = "Time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            //Stop Game

            
           
           // Time.timeScale = 0f;
            remainingTimeText.text = "Lives: " + Lives.lives.ToString(); // PlayerPrefs.GetInt("lives")
            timeLimitText.text = PlayerPrefs.GetString("name");
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
