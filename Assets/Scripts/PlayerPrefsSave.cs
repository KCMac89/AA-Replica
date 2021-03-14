using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPrefsSave : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    public void PlayerPrefSave()
    {

        //   PlayerPrefs.SetString("lives", livesText.text);
        //  PlayerPrefs.SetString("score", scoreText.text);
        // PlayerPrefs.SetString("scene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("lives", Lives.lives.ToString());
        PlayerPrefs.SetString("score", Score.PinCount.ToString());
        
        PlayerPrefs.Save();

    }
}
