using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{

    public Text scoreText;
  
    void Start()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
    }
   

}
