using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{

    public Text textLives;

   
    void Start()
    {
     
    }


    void Update()
    {
        textLives.text = "Lives: "  + Lives.lives.ToString();
    }
}
