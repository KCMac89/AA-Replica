using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyLoad : MonoBehaviour
{


    public Text livesText;
    public Text scoreText;
    public static bool isLoad = false;

    public void PlayerPrefLoad()
    {

        livesText.text = PlayerPrefs.GetString("lives");
        scoreText.text = PlayerPrefs.GetString("score");
        //string mySavedScene = PlayerPrefs.GetString("scene");
        isLoad = true;
        //SceneManager.LoadScene(mySavedScene);

    }


}
