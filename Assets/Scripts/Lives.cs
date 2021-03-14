using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Dropdown dropdown;
    public static int lives;

    public void PlayerLives()
    {
        switch (dropdown.value)
        {
            
            case 1:
                lives = 1;
                break;
            case 2:
                lives = 2;
                break;
            case 3:
                lives = 3;
                break;
            case 4:
                lives = 4;
                break;
            case 5:
                lives = 5;
                break;
            default:
                lives = 3;
                break;

        }

        PlayerPrefs.SetInt("lives", lives);
    }

}
