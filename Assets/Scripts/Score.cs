using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int PinCount = 0;
    public Text text;

    void Start()
    {
        PinCount = 0;
       // PlayerPrefs.SetInt("score", PinCount);
    }


    void Update()
    {
        text.text = PinCount.ToString();
       // PlayerPrefs.SetInt("score", PinCount);
        //text.text = PlayerPrefs.GetString("score").ToString();
    }
}
